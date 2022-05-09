using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Models
{
    public class RegisterInformation
    {
        Credentials credentials { get; set; }
        List<Driver> drivers { get; set; }
        List<Car> cars { get; set; }
    }
}
