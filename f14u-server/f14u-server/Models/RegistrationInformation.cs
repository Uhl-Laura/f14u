using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Models
{
    public class RegistrationInformation
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string TeamName { get; set; }
        public string FirstDriverName { get; set; } 
        public string SecondDriverName { get; set; }
        public string DriverImageUrl { get; set; }
        public string CarImageUrl { get; set; }
    }
}
