namespace NeighboursCommunitySystem.Services.Data.Contracts
{
    using System.Linq;
    using Models;

    public interface ICommunitiesService
    {
        IQueryable<Community> All();

        IQueryable<Community> ByCurrentUser();

        int Add(string Name, string Description = null);
    }
}
