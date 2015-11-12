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

    public class TaxesService : ITaxesService
    {
        private readonly IRepository<Tax> taxes;

        public TaxesService(IRepository<Tax> taxes)
        {
            this.taxes = taxes;
        }

        public IQueryable<Tax> GetByCommunityId(int Id)
        {
            var result = taxes.All().Where(t => t.Community.Id == Id);

            return result;
        }
    }
}
