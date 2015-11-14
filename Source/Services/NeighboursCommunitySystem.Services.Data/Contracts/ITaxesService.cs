namespace NeighboursCommunitySystem.Services.Data.Contracts
{
    using NeighboursCommunitySystem.Models;
    using System.Linq;

    public interface ITaxesService : IService<Tax>
    {
        IQueryable<Tax> GetByCommunityId(int Id);
    }
}
