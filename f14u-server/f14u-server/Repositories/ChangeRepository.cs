using f14u_server.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Repositories
{
    public class ChangeRepository : RepositoryBase<Change>, IChangeRepository
    {
        public ChangeRepository(IMongoCollection<Change> collection) : base(collection)
        {

        }
    }
}
