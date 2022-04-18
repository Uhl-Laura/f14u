using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using f14u_server.Models;
using f14u_server.Services;
using Microsoft.AspNetCore.Mvc;

namespace f14u_server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CredentialsController : ControllerBase
    {
        private CredentialsService CredentialsService { get; set; }
        public CredentialsController(CredentialsService service)
        {
            CredentialsService = service;
        }
        [HttpGet]
        public ActionResult<List<Credentials>> Get()
        {
            Console.WriteLine("GET request received for credentials.");
            var credentials = CredentialsService.GetCredentials();
            if (credentials == null)
            {
                return NotFound();
            }
            return credentials;
        }
        [HttpPost("login")]
        public ActionResult<bool> Login(Credentials credentials)
        {
            try
            {
                return CredentialsService.VerifyLoginCredentials(credentials);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        [HttpPost("register")]
        public ActionResult<bool> Register(RegisterInformation registerInformation)
        {
            return false;
        }
    }
}
