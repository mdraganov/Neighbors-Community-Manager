namespace NeighboursCommunitySystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;

    public class NeighboursCommunityDbContext : IdentityDbContext<User>
    {
        public NeighboursCommunityDbContext()
            : base("NeighboursCommunitySystem", throwIfV1Schema: false)
        {
        }

        public IDbSet<Tax> Taxes { get; set; }

        public static NeighboursCommunityDbContext Create()
        {
            return new NeighboursCommunityDbContext();
        }
    }
}