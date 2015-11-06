namespace NeighboursCommunitySystem.Services.Contracts
{
    using System.Linq;
    using Data.Repositories;
    using Models;

    public interface IProposalService
    {
        IQueryable<Proposal> All();
    }
}