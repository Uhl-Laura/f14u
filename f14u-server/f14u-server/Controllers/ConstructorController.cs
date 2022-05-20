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
        [HttpPost("Drivers/{driverName}")]
        public async Task<ActionResult> ChangeDriver(Driver driver, string driverName)
        {
            try
            {
                await ConstructorService.ChangeDriver(driverName, driver);
                return Ok("Driver changed succesfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }
        [HttpPost("CarComponents/{driverName}")]
        public async Task<ActionResult> ChangeCarComponent(string driverName,CarComponent carComponent)
        {
            try
            {
                await ConstructorService.ChangeComponentForCar(driverName,carComponent);
                return Ok("ComponentChanged");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }

        }
        [HttpGet("CarComponents/{driverName}")]
        public ActionResult<Car> CarInformation(string driverName)
        {
            try
            {
                return ConstructorService.GetInformationAboutACar(driverName);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }
        [HttpGet("CarComponents/{driverName}")]
        public ActionResult<List<CarComponent>> GetCarComponentsForADriver(string driverName)
        {
            try
            {
                return ConstructorService.GetAllComponentsForACar(driverName);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }
        [HttpGet("name/{username}")]
        public ActionResult<String> GetNameByConstructorUsername(string username)
        {
            try
            {
                return ConstructorService.GetNameByUsername(username);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }
        [HttpGet("driver/name/{username}")]
        public ActionResult<String> GetDriverNameByUsername(string username)
        {
            try
            {
                return ConstructorService.GetDriverNameByUsername(username);
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500);
            }
        }
    }
}
