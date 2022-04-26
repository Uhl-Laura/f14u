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
        [HttpGet("users")]
        public ActionResult<List<string>> GetUsernames()
        {
            Console.WriteLine("GET request received for credentials.");
            var usernames = CredentialsService.GetUsers();
            if (usernames == null)
            {
                return NotFound();
            }
            return usernames;
        }
        [HttpGet("users/{username}")]
        public ActionResult<bool> GetUsernameAvailability(string username)
        {
            Console.WriteLine("GET request received for user availability.");
            try
            {
                return CredentialsService.IsUsernameTaken(username);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }
        [HttpPost("login")]
        public ActionResult<string> Login(Credentials credentials)
        {
            try
            {
                return CredentialsService.VerifyLoginCredentials(credentials);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }
        [HttpPost("register/{role}")]
        public async Task<ActionResult> Register(RegistrationInformation registrationInformation, string role)
        {
            Console.WriteLine("Register request is received.");
            try
            {
                Console.WriteLine("Register request is processing...");
                if (await CredentialsService.RegisterUser(registrationInformation, role)) 
                {
                    Console.WriteLine("Register request completed.");
                    return Ok("Successfully registered");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
            return BadRequest();
        }
    }
}
