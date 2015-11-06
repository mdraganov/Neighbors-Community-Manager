namespace NeighboursCommunitySystem.Data.DbContexts
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
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

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public static NeighboursCommunityDbContext Create()
        {
            return new NeighboursCommunityDbContext();
        }
    }
}