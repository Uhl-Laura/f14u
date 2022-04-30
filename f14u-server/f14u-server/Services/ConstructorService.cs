using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using f14u_server.Models;
using f14u_server.Repositories;

namespace f14u_server.Services
{
    public class ConstructorService
    {
        public IRepositoryWrapper Repository { get; set; }
        public ConstructorService(IRepositoryWrapper repository)
        {
            Repository = repository;
        }
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
    }
}
