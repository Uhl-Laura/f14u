using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using f14u_server.Models;
using MongoDB.Driver;

namespace f14u_server.Repositories
{
    public class CredentialsRepository : RepositoryBase<Credentials>, ICredentialsRepository
    {
        public CredentialsRepository(IMongoCollection<Credentials> collection) : base(collection)
        {

        }
    }
}
