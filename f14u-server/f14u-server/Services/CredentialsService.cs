using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using f14u_server.Models;
using f14u_server.Repositories;

namespace f14u_server.Services
{
    public class CredentialsService
    {
        public IRepositoryWrapper Repository { get; set; }
        public CredentialsService(IRepositoryWrapper repository)
        {
            Repository = repository;
        }
        public List<Credentials> GetCredentials()
        {
            return Repository.CredentialsRepository.GetAll().ToList();
        }
    }
}
