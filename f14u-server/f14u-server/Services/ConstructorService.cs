<<<<<<< HEAD
﻿using f14u_server.Models;
using f14u_server.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using f14u_server.Models;
using f14u_server.Repositories;
>>>>>>> 6ccada85e52d299e6f57d2cba011e05f27264f96

namespace f14u_server.Services
{
    public class ConstructorService
    {
        public IRepositoryWrapper Repository { get; set; }
        public ConstructorService(IRepositoryWrapper repository)
        {
            Repository = repository;
        }
<<<<<<< HEAD
        public List<Driver> GetDrivers(string constructorName)
        {
            var drivers = Repository.DriversRepository.GetAll().Where(item => item.TeamName == constructorName).ToList();
            return drivers;
=======
        public async Task CreateNewConstructor(string constructorName, string username, string firstDriverName, string secondDriverName)
        {
            Constructor constructor = new Constructor
            {
                Username = username,
                Name = constructorName
            };
            await Repository.ConstructorsRepository.InsertOneAsync(constructor);
            await AddNewDriver(firstDriverName, null, constructorName);
            await AddNewDriver(secondDriverName, null, constructorName);
            await AsignConstructorCarToDriver(constructorName, firstDriverName);
            await AsignConstructorCarToDriver(constructorName, secondDriverName);

>>>>>>> 6ccada85e52d299e6f57d2cba011e05f27264f96
        }
        public async Task AddNewDriver(string name, string username, string teamName)
        {
            Driver driver = new Driver
            {
                DriverName = name,
                Username = username,
                TeamName = teamName
            };
            await Repository.DriversRepository.InsertOneAsync(driver);
        }
        public async Task AsignConstructorCarToDriver(string teamName, string driverName)
        {
            Car car = new Car
            {
                Driver = driverName,
                Team = teamName
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
<<<<<<< HEAD
        public async Task ChangeComponentForCar(string driverName,CarComponent carComponent)
        {
            var componentToChange = Repository.CarComponentsRepository.GetAll().Where(item => item.Name == carComponent.Name).FirstOrDefault();
            if (componentToChange.AvailabilityCount < 1)
            {
                Console.WriteLine("Component avability is over the limit of change");
                await Repository.CarComponentsRepository.ReplaceOneAsync(carComponent);
                carComponent.AvailabilityCount = carComponent.AvailabilityCount - 1;
            }
            else
            {
                await Repository.CarComponentsRepository.ReplaceOneAsync(carComponent);
                carComponent.AvailabilityCount = carComponent.AvailabilityCount - 1;
            }
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
                await Repository.DriversRepository.ReplaceOneAsync(driverName, driver);
            }
        }
        public bool isDriverInConstructorsDriverList(string driverName)
        {
            return GetDrivers().Any(item => item == driverName);
        }
        public List<string> GetDrivers()
        {
            List<string> drivers = new List<string>();
            return Repository.DriversRepository.GetAll().Select(item => item.DriverName).ToList();
        }

=======
>>>>>>> 6ccada85e52d299e6f57d2cba011e05f27264f96
    }
}
