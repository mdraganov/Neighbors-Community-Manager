namespace NeighboursCommunitySystem.Data.DbContexts
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class NeighboursCommunityDbContext : IdentityDbContext<User>, INeighboursCommunityDbContext
    {
        public NeighboursCommunityDbContext()
            : base("NeighboursCommunitySystem", throwIfV1Schema: false)
        {
        }

        public IDbSet<Tax> Taxes { get; set; }

        public IDbSet<Proposal> Proposals { get; set; }

        public static NeighboursCommunityDbContext Create()
        {
            return new NeighboursCommunityDbContext();
        }
    }
}