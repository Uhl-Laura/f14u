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
        public List<string> GetUsers()
        {
            List<string> usernames = new List<string>();
            return Repository.CredentialsRepository.GetAll().Select(item => item.Username).ToList();  
        }
        public bool IsUsernameTaken(string username)
        {
            return GetUsers().Any(item => item == username);
        }
        public string VerifyLoginCredentials(Credentials credentials)
        {
            var storedCredentials = Repository.CredentialsRepository.GetAll().Where(item => item.Username == credentials.Username).FirstOrDefault();
            if (credentials == null)
                return null;
            if (storedCredentials.Password == credentials.Password)
                return storedCredentials.Role;
            return null;
        }
        public async Task<bool> RegisterUser(RegistrationInformation registrationInformation, string role)
        {
            return role switch
            {
                "steward" => await RegisterSteward(registrationInformation),
                "constructor" => await RegisterConstructor(registrationInformation),
                "driver" => await RegisterDriver(registrationInformation),
                _ => false,
            };
        }
        public async Task<bool> RegisterSteward(RegistrationInformation registrationInformation)
        {
            Credentials credentials = new Credentials
            {
                Username = registrationInformation.Username,
                Password = registrationInformation.Password,
                Role = "steward"
            };
            Steward steward = new Steward
            {
                Name = registrationInformation.Name,
                Username = registrationInformation.Username
            };
            await Repository.CredentialsRepository.InsertOneAsync(credentials);
            await Repository.StewardsRepository.InsertOneAsync(steward);
            return true;
        }
        public async Task<bool> RegisterConstructor(RegistrationInformation registrationInformation)
        {
            return false;
        }
        public async Task<bool> RegisterDriver(RegistrationInformation registrationInformation)
        {
            Credentials credentials = new Credentials
            {
                Username = registrationInformation.Username,
                Password = registrationInformation.Password,
                Role = "driver"
            };
            Driver driver = new Driver
            {
                DriverName = registrationInformation.Name,
                Username = registrationInformation.Username,
                TeamName = registrationInformation.TeamName,
            };
            await Repository.CredentialsRepository.InsertOneAsync(credentials);
            await Repository.DriversRepository.InsertOneAsync(driver);
            return true;
        }
    }
}
