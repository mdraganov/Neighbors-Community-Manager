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
    using DtoModels.Taxes;

    public class TaxesService : ITaxesService
    {
        private readonly IRepository<Tax> taxes;

        public TaxesService(IRepository<Tax> taxes)
        {
            this.taxes = taxes;
        }

        public IQueryable<Tax> All()
        {
            return taxes.All();
        }

        public IQueryable<Tax> GetByCommunityId(int Id)
        {
            return taxes.All().Where(t => t.Community.Id == Id);
        }

        public int AddByCommunityId(int communityId, TaxDataTransferModel model)
        {
            var tax = new Tax
            {
                Name = model.Name,
                Price = model.Price,
                Deadline = model.Deadline,
                Description = model.Description,
                CommunityId = communityId
            };

            taxes.Add(tax);
            taxes.SaveChanges();

            return tax.Id;
        }
    }
}
