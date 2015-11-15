namespace NeighboursCommunitySystem.Services.Data.Contracts
{
    using NeighboursCommunitySystem.Models;
    using DtoModels.Taxes;
    using System.Linq;

    public interface ITaxesService : IService<Tax>
    {
        IQueryable<Tax> GetByCommunityId(int id);

        int AddByCommunityId(int id, TaxDataTransferModel model);

        void DeleteById(int Id);
    }
}
