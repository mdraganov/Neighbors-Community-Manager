namespace NeighboursCommunitySystem.Services.Data.Contracts
{
    using Models;
    using System.Linq;

    public interface IProposalsService : IService
    {
        IQueryable<Proposal> All();

    }
}
