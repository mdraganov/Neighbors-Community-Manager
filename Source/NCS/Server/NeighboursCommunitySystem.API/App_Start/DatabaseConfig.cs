namespace NeighboursCommunitySystem.API
{
    using Data;
    using Data.Migrations;
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