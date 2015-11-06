namespace NeighboursCommunitySystem.Services.Data.Contracts
{
    using Models;
    using System.Linq;

    public interface IProposalService : IService
    {
        IQueryable<Proposal> All();

    }
}
