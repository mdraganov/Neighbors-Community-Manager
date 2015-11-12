namespace NeighboursCommunitySystem.Services.Data.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;
    using Models;
    using NeighboursCommunitySystem.Data.Repositories;

    public class TaxesService : IService
    {
        private readonly IRepository<Tax> taxes;
    }
}
