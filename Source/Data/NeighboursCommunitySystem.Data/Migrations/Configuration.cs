namespace NeighboursCommunitySystem.Data.Migrations
{
    using System.Linq;
    using System.Data.Entity.Migrations;
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

            var adminExists = context.Users.Any(x => x.UserName == "Administrator");
            var accountantExists = context.Users.Any(x => x.UserName == "Accountant");

            if (!adminExists)
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var userStore = new UserStore<User>(context);
                var userManager = new UserManager<User>(userStore);

                var adminRole = new IdentityRole { Name = "Administrator" };
                roleManager.Create(adminRole);

                var admin = new User()
                {
                    UserName = "Administrator",
                    Email = "archer@gmail.com",
                    Id = "1",
                    FirstName = "Archer",
                    LastName = "Jr",
                    PhoneNumber = "0887482921",
                    ApartmentNumber = 1
                };

                userManager.Create(admin, "123456");
                userManager.AddToRole(admin.Id, "Administrator");

                context.SaveChanges();
            }

            if(!accountantExists)
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var userStore = new UserStore<User>(context);
                var userManager = new UserManager<User>(userStore);

                var accountantRole = new IdentityRole { Name = "Accountant" };
                roleManager.Create(accountantRole);

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

                userManager.Create(accountant, "123456");
                userManager.AddToRole(accountant.Id, "Accountant");

                context.SaveChanges();
            }
        }
    }
}