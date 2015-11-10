namespace NeighboursCommunitySystem.Services.Data
{
    using System;
    using System.Linq;
    using Services.Data.Contracts;
    using Models;
    using NeighboursCommunitySystem.Data.Repositories;
    
    // Under construction.

    public class CommunitiesService : ICommunitiesService
    {
        private readonly IRepository<Community> communities;

        public CommunitiesService(IRepository<Community> dbCommunities)
        {
            this.communities = dbCommunities;
        }

        public int Add(string name, string description = null)
        {
            var newCommunity = new Community()
            {
                Name = name,
                Description = description
            };

            communities.Add(newCommunity);
            communities.SaveChanges();

            return newCommunity.Id;
        }

        public IQueryable<Community> All()
        {
            return communities.All();
        }

        public IQueryable<Community> ByCurrentUser()
        {
            throw new NotImplementedException();
        }
    }
}
