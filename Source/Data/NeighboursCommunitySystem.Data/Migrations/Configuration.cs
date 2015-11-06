namespace NeighboursCommunitySystem.Data.Migrations
{
    using DbContexts;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<NeighboursCommunityDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "NeighboursCommunitySystem.Data.NeighboursCommunityDbContext";
        }

        protected override void Seed(NeighboursCommunityDbContext context)
        {
            // TODO: SEED ADMIN ROLES LATER (tenants council)
            // ADMIN BUTTON -> CONTROL PANNEL
        }
    }
}