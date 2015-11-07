namespace NeighboursCommunitySystem.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DbContexts;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

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
            // ADMIN BUTTON -> CONTROL PANNEL
            if (!context.Users.Any())
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var adminRole = new IdentityRole {Name = "Administrator"};
                var accountantRole = new IdentityRole {Name = "Accountant"};

                roleManager.Create(adminRole);
                roleManager.Create(accountantRole);

                var userStore = new UserStore<User>(context);
                var userManager = new UserManager<User>(userStore);

                var admin = new User()
                {
                    UserName = "Admin",
                    Email = "archer@gmail.com",
                    Id = "1",
                    FirstName = "Archer",
                    LastName = "Jr",
                    PhoneNumber = "0887482921",
                    ApartmentNumber = 1
                };

                var accountant = new User()
                {
                    UserName = "Accountant",
                    Email = "cyril@gmail.com",
                    Id = "2",
                    FirstName = "Cyril",
                    LastName = "Figgis",
                    PhoneNumber = "0883333312",
                    ApartmentNumber = 2
                };

                userManager.Create(admin);
                userManager.Create(accountant);

                userManager.AddToRole(admin.Id, "Administrator");
                userManager.AddToRole(accountant.Id, "Accountant");
            }
        }
    }
}