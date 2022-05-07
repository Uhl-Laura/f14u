using f14u_server.Models;
using f14u_server.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConstructorController : ControllerBase
    {
        private ConstructorService ConstructorService { get; set; }
        public ConstructorController(ConstructorService construcorService)
        {
            ConstructorService = construcorService;
        }
        [HttpGet("Drivers/{constructorName}")]
        public ActionResult<List<Driver>> GetDrivers(string constructorName)
        {
            try
            {
                return ConstructorService.GetDrivers(constructorName);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;

        }
    }
}
