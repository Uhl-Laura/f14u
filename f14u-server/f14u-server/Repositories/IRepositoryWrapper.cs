using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace f14u_server.Repositories
{
    public interface IRepositoryWrapper
    {
        public ICredentialsRepository CredentialsRepository { get; }
<<<<<<< HEAD
        public IPenaltiesRepository PenaltiesRepository { get; }
        public IConstructorsRepository ConstructorsRepository { get; }
        public IDriversRepository DriversRepository { get; }
=======
        public IStewardsRepository StewardsRepository { get; }
        public IDriversRepository DriversRepository { get; }
        public IConstructorsRepository ConstructorsRepository { get; }
        public ICarsRepository CarsRepository { get; }
        public ICarComponentsRepository CarComponentsRepository { get; }
>>>>>>> 6ccada85e52d299e6f57d2cba011e05f27264f96
    }
}
