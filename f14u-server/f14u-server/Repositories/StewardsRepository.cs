using f14u_server.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Repositories
{
    public class StewardsRepository : RepositoryBase<Steward>, IStewardsRepository
    {
        public StewardsRepository(IMongoCollection<Steward> collection) : base(collection)
        {

        }
    }
}
    
