namespace NeighboursCommunitySystem.API
{
    using Data.Migrations;
    using Data.DbContexts;
    using System.Data.Entity;

    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NeighboursCommunityDbContext, Configuration>());
            NeighboursCommunityDbContext.Create().Database.Initialize(true);
        }
    }
}