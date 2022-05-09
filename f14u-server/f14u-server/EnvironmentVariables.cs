using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server
{
    public class EnvironmentVariables
    {
        public static string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
        public static string databaseName = Environment.GetEnvironmentVariable("DATABASE_NAME");
        public static string credentialsTableName = Environment.GetEnvironmentVariable("CREDENTIALS_TABLE_NAME");
<<<<<<< HEAD
        public static string constructorTableName = Environment.GetEnvironmentVariable("CONSTRUCTOR_TABLE_NAME");
        public static string driverTableName = Environment.GetEnvironmentVariable("DRIVER_TABLE_NAME");
=======
        public static string stewardsTableName = Environment.GetEnvironmentVariable("STEWARDS_TABLE_NAME");
        public static string driversTableName = Environment.GetEnvironmentVariable("DRIVERS_TABLE_NAME");
        public static string constructorsTableName = Environment.GetEnvironmentVariable("CONSTRUCTORS_TABLE_NAME");
        public static string carsTableName = Environment.GetEnvironmentVariable("CARS_TABLE_NAME");
        public static string carComponentsTableName = Environment.GetEnvironmentVariable("CAR_COMPONENTS_TABLE_NAME");
>>>>>>> 6ccada85e52d299e6f57d2cba011e05f27264f96
    }
}
