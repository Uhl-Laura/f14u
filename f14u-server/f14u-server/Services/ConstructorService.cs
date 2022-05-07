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
        public List<Driver> GetDrivers(string constructorName)
        {
            var drivers = Repository.DriversRepository.GetAll().Where(item => item.TeamName == constructorName).ToList();
            return drivers;
        }
            

       
    }
}
