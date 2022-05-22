using f14u_server.Models;
using f14u_server.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace f14u_server.Services
{
    public class ConstructorService
    {
        public IRepositoryWrapper Repository { get; set; }
        public ConstructorService(IRepositoryWrapper repository)
        {
            Repository = repository;
        }
        
        public async Task CreateNewConstructor(string constructorName, string username, string firstDriverName, string secondDriverName,string imageUrlCarForDriver)
        {
            var drivers = Repository.DriversRepository.GetAll().Where(item => item.TeamName == constructorName).ToList();
            Constructor constructor = new Constructor
            {
                Username = username,
                Name = constructorName
            };
            await Repository.ConstructorsRepository.InsertOneAsync(constructor);
            await AddNewDriver(firstDriverName, null, constructorName, null);
            await AddNewDriver(secondDriverName, null, constructorName, null);
            await AsignConstructorCarToDriver(constructorName, firstDriverName,imageUrlCarForDriver);
            await AsignConstructorCarToDriver(constructorName, secondDriverName,imageUrlCarForDriver);
        }
        public async Task AddNewDriver(string name, string username, string teamName,string imageUrl)
        {
            Driver driver = new Driver
            {
                DriverName = name,
                Username = username,
                TeamName = teamName,
                ImageURL = imageUrl

            };
            var driverInDataBase = Repository.DriversRepository.GetAll().Where(item => item.DriverName == driver.DriverName && item.TeamName == driver.TeamName).FirstOrDefault();
            if(driverInDataBase == null)
            {
                await Repository.DriversRepository.InsertOneAsync(driver);
            }
            else
            {
                await Repository.DriversRepository.DeleteManyAsync(item => item.DriverName == driverInDataBase.DriverName);
                await Repository.DriversRepository.InsertOneAsync(driver);

            }
            await Repository.DriversRepository.ReplaceOneAsync(item => item.DriverName == driver.DriverName && item.TeamName == driver.TeamName, driver);
        }
        public async Task AsignConstructorCarToDriver(string teamName, string driverName, string imageURL)
        {
            Car car = new Car
            {
                Driver = driverName,
                Team = teamName,
                ImageUrl = imageURL
            };
            await Repository.CarsRepository.InsertOneAsync(car);
            await GenerateComponentsForCar(teamName, driverName);
        }
        public async Task GenerateComponentsForCar(string teamName, string driverName)
        {
            await CreateNewCarComponents(teamName, driverName, "engine");
            await CreateNewCarComponents(teamName, driverName, "motor generator");
            await CreateNewCarComponents(teamName, driverName, "turbo charger");
            await CreateNewCarComponents(teamName, driverName, "energy store");
            await CreateNewCarComponents(teamName, driverName, "control electronics");
            await CreateNewCarComponents(teamName, driverName, "exhaust");
            await CreateNewCarComponents(teamName, driverName, "gearbox");
        }
        public async Task CreateNewCarComponents(string teamName, string driverName, string componentName)
        {
            CarComponent carComponent = new CarComponent
            {
                Team = teamName,
                Driver = driverName,
                Name = componentName
            };
            await Repository.CarComponentsRepository.InsertOneAsync(carComponent);
        }
        public async Task ChangeComponentForCar(string driverName,CarComponent carComponent)
        {
            var componentToChange = Repository.CarComponentsRepository.GetAll().Where(item => item.Name == carComponent.Name &&
                                                                                              item.Driver == carComponent.Driver)
                                                                       .FirstOrDefault();
            Change change = new Change
            {
                CarComponent = carComponent.Name,
                DriverName = driverName,
                TeamName = carComponent.Team,
            };
            componentToChange.AvailabilityCount--;
            await Repository.CarComponentsRepository.ReplaceOneAsync(item => item.Name == carComponent.Name &&
                                                                             item.Driver == carComponent.Driver, componentToChange);
            change.isLegal = componentToChange.AvailabilityCount >= 0;
            await Repository.ChangeRepository.InsertOneAsync(change);
        }
        public List<Driver> GetDriversByConstructor(string constructorName) 
        {
            return Repository.DriversRepository.GetAll().Where(item => item.TeamName == constructorName).ToList();
        }
        public async Task ChangeDriver(string driverName, Driver driver)
        {
            var driverToChange = Repository.DriversRepository.GetAll().Where(item => item.DriverName == driverName).FirstOrDefault();
            if (driverToChange == null) 
            {
                Console.WriteLine("There is no driver with this name in the Database");
            }
            else
            {
                await Repository.DriversRepository.DeleteManyAsync(item => item.DriverName == driverName);
                await Repository.DriversRepository.InsertOneAsync(driver);
            }
        }
        public List<Driver> GetDrivers(string constructorName)
        {
            return Repository.DriversRepository.GetAll().Where(item => item.TeamName == constructorName).ToList();
        }
        public Car GetInformationAboutACar(string driverName)
        {
            return Repository.CarsRepository.GetAll().Where(item => item.Driver == driverName).FirstOrDefault();
        }
        public List<CarComponent> GetAllComponentsForACar(string driverName)
        {
            return Repository.CarComponentsRepository.GetAll().Where(item => item.Driver == driverName).ToList();
        }
        public List<string> GetAllComponentsNameForACar()
        {
            var carComponentNames = Repository.CarComponentsRepository.GetAll().Select(item => item.Name).ToList();
            return carComponentNames;
        }
        public Driver GetDriverInformationByName(string driverName)
        {
            return Repository.DriversRepository.GetAll().Where(item => item.DriverName == driverName).FirstOrDefault();
        }
    }
}
