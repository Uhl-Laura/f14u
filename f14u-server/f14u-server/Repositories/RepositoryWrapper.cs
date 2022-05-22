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
        public IConstructorsRepository ConstructorsRepository { get; set; }
        public IDriversRepository DriversRepository { get; set; }
        public IStewardsRepository StewardsRepository { get; set; }
        public ICarsRepository CarsRepository { get; set; }
        public IChangeRepository ChangeRepository { get; set; }
        public ICarComponentsRepository CarComponentsRepository { get; set; }
        public IPenaltiesRepository PenaltiesRepository { get; set; }
        public RepositoryWrapper()
        {
            var client = new MongoClient(EnvironmentVariables.connectionString);
            var database = client.GetDatabase(EnvironmentVariables.databaseName);
            CredentialsRepository = new CredentialsRepository(database.GetCollection<Credentials>(EnvironmentVariables.credentialsTableName));
            ConstructorsRepository = new ConstructorsRepository(database.GetCollection<Constructor>(EnvironmentVariables.constructorTableName));
            DriversRepository = new DriversRepository(database.GetCollection<Driver>(EnvironmentVariables.driverTableName));
            StewardsRepository = new StewardsRepository(database.GetCollection<Steward>(EnvironmentVariables.stewardsTableName));
            DriversRepository = new DriversRepository(database.GetCollection<Driver>(EnvironmentVariables.driverTableName));
            ConstructorsRepository = new ConstructorsRepository(database.GetCollection<Constructor>(EnvironmentVariables.constructorTableName));
            CarsRepository = new CarsRepository(database.GetCollection<Car>(EnvironmentVariables.carsTableName));
            CarComponentsRepository = new CarComponentsRepository(database.GetCollection<CarComponent>(EnvironmentVariables.carComponentsTableName));
            ChangeRepository = new ChangeRepository(database.GetCollection<Change>(EnvironmentVariables.ChangeTableName));
            PenaltiesRepository = new PenaltiesRepository(database.GetCollection<Penalty>(EnvironmentVariables.PenaltiesTableName));
        }
    }
}
