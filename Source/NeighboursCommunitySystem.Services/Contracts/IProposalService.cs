namespace NeighboursCommunitySystem.Services
{
    using System.Linq;
    using NeighboursCommunitySystem.Data.Repositories;
    using NeighboursCommunitySystem.Models;

    public interface IProposalService
    {
        IQueryable<Proposal> All();
    }
}