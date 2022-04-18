using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using f14u_server.Models;
using f14u_server.Repositories;
using Google.Apis.Admin.Directory.directory_v1.Data;

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
        public bool VerifyLoginCredentials(Credentials credentials)
        {
            var storedCredentials = Repository.CredentialsRepository.GetAll().Where(item => item.Username == credentials.Username).FirstOrDefault();
            if (credentials == null)
                return false;
            if (storedCredentials.Password == credentials.Password)
                return true;
            return false;
        }
    }
}
