using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using f14u_server.Models;
using MongoDB.Driver;

namespace f14u_server.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        public ICredentialsRepository CredentialsRepository{ get; set; }
        public IStewardsRepository StewardsRepository { get; set; }
        public IDriversRepository DriversRepository { get; set; }
        public IConstructorsRepository ConstructorsRepository { get; set; }
        public ICarsRepository CarsRepository { get; set; }
        public ICarComponentsRepository CarComponentsRepository { get; set; }
        public RepositoryWrapper()
        {
            var client = new MongoClient(EnvironmentVariables.connectionString);
            var database = client.GetDatabase(EnvironmentVariables.databaseName);
            CredentialsRepository = new CredentialsRepository(database.GetCollection<Credentials>(EnvironmentVariables.credentialsTableName));
            StewardsRepository = new StewardsRepository(database.GetCollection<Steward>(EnvironmentVariables.stewardsTableName));
            DriversRepository = new DriversRepository(database.GetCollection<Driver>(EnvironmentVariables.driversTableName));
            ConstructorsRepository = new ConstructorsRepository(database.GetCollection<Constructor>(EnvironmentVariables.constructorsTableName));
            CarsRepository = new CarsRepository(database.GetCollection<Car>(EnvironmentVariables.carsTableName));
            CarComponentsRepository = new CarComponentsRepository(database.GetCollection<CarComponent>(EnvironmentVariables.carComponentsTableName));
        }
    }
}
