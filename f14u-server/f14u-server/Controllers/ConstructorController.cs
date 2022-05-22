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
        [HttpGet("Changes/{driverName}")]
        public ActionResult<List<Change>> GetChangesForACar(string driverName)
        {
            try
            {
                return ConstructorService.GetChangesForACar(driverName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }
        [HttpPost("Drivers/{driverName}")]
        public async Task<ActionResult> ChangeDriver(string driverName, Driver driver)
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
        [HttpGet("Car/{driverName}")]
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
        [HttpGet("Components/{driverName}")]
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
        [HttpGet("DriverInformation/{drivername}")]
        public ActionResult<Driver> GetDriverInformationByName(string drivername)
        {
            try
            {
                return ConstructorService.GetDriverInformationByName(drivername);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }
    }
}
