using f14u_server.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Repositories
{
    public class ConstructorsRepository : RepositoryBase<Constructor>, IConstructorsRepository
    {
        public ConstructorsRepository(IMongoCollection<Constructor> collection) : base(collection)
        {

        }
    }
}
