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
        public ConstructorService ConstructorService { get; set; }
        public CredentialsService(IRepositoryWrapper repository, ConstructorService constructorService)
        {
            Repository = repository;
            ConstructorService = constructorService;
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
        public List<Driver> GetUnregisteredDrivers()
        {
            return Repository.DriversRepository.GetAll().Where(item => item.Username == null).ToList();
        }
        public async Task RegisterUser(RegistrationInformation registrationInformation, string role)
        {
            switch(role)
            {
                case "steward":
                    await RegisterSteward(registrationInformation);
                    break;
                case "constructor":
                    await RegisterConstructor(registrationInformation);
                    break;
                case "driver":
                    await RegisterDriver(registrationInformation);
                    break;
            }
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
        public async Task RegisterConstructor(RegistrationInformation registrationInformation)
        {
            Credentials credentials = new Credentials
            {
                Username = registrationInformation.Username,
                Password = registrationInformation.Password,
                Role = "constructor"
            };
            await Repository.CredentialsRepository.InsertOneAsync(credentials);
            await ConstructorService.CreateNewConstructor(registrationInformation.TeamName, registrationInformation.Username, registrationInformation.FirstDriverName, registrationInformation.SecondDriverName);
        }
        public async Task RegisterDriver(RegistrationInformation registrationInformation)
        {
            Credentials credentials = new Credentials
            {
                Username = registrationInformation.Username,
                Password = registrationInformation.Password,
                Role = "driver"
            };
            await Repository.CredentialsRepository.InsertOneAsync(credentials);
            await ConstructorService.AddNewDriver(registrationInformation.Name, registrationInformation.Username, registrationInformation.TeamName);
        }
    }
}