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
        public static string constructorTableName = Environment.GetEnvironmentVariable("CONSTRUCTOR_TABLE_NAME");
        public static string driverTableName = Environment.GetEnvironmentVariable("DRIVERS_TABLE_NAME");
        public static string stewardsTableName = Environment.GetEnvironmentVariable("STEWARDS_TABLE_NAME");
        public static string carsTableName = Environment.GetEnvironmentVariable("CARS_TABLE_NAME");
        public static string carComponentsTableName = Environment.GetEnvironmentVariable("CAR_COMPONENTS_TABLE_NAME");
        public static string ChangeTableName = Environment.GetEnvironmentVariable("CAR_CHANGE_TABLE_NAME");
        public static string PenaltiesTableName = Environment.GetEnvironmentVariable("PENALTIES_TABLE_NAME");
    }
}
