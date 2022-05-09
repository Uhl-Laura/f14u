<<<<<<< HEAD
﻿using f14u_server.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using f14u_server.Models;
using MongoDB.Driver;
>>>>>>> 6ccada85e52d299e6f57d2cba011e05f27264f96

namespace f14u_server.Repositories
{
    public class CarComponentsRepository : RepositoryBase<CarComponent>, ICarComponentsRepository
    {
        public CarComponentsRepository(IMongoCollection<CarComponent> collection) : base(collection)
        {

        }
<<<<<<< HEAD

=======
>>>>>>> 6ccada85e52d299e6f57d2cba011e05f27264f96
    }
}
