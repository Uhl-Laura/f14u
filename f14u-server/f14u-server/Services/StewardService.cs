using f14u_server.Models;
using f14u_server.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Services
{
    public class StewardService
    {
        public IRepositoryWrapper Repository { get; set; }
        public StewardService(IRepositoryWrapper repository)
        {
            Repository = repository;
        }
        public List<Change> GetAllChanges()
        {
            return Repository.ChangeRepository.GetAll().ToList();
        }
        public async Task GivePenalty(Penalty penalty)
        {
            await Repository.PenaltiesRepository.InsertOneAsync(penalty);
        }
        public List<Penalty> ShowAllPenaltiesForADriver(string driverName)
        {
            return Repository.PenaltiesRepository.GetAll().Where(item => item.DriverName == driverName).ToList();
        } 

    }
}
