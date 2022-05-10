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
    [Route("[strward]")]
    public class StewardController : ControllerBase
    {
        private StewardService StewardService { get; set; }
        public StewardController(StewardService stewardService)
        {
            StewardService = stewardService;
        }
        [HttpGet("Steward")]
        public ActionResult<List<Change>> GetAllChanges()
        {
            try
            {
                return StewardService.GetAllChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500);
            }
        }
    }
}
