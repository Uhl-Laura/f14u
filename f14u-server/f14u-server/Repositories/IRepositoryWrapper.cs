using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Repositories
{
    public interface IRepositoryWrapper
    {
        public ICredentialsRepository CredentialsRepository { get; }
        public IStewardsRepository StewardsRepository { get; }
        public IDriversRepository DriversRepository { get; }
    }
}
