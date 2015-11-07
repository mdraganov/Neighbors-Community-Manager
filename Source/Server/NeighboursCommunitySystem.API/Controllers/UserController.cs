namespace NeighboursCommunitySystem.API.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data.DbContexts;
    using DtoModels.Users;

    public class UserController : ApiController
    {
        // Just for testing purposes - will be fixed.
        public IHttpActionResult GetAll()
        {
            var db = new NeighboursCommunityDbContext();

            var users = db.Users
                .Select(x => new UserDetailedResponseModel()
                {
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    ApartmentNumber = x.ApartmentNumber,
                    Proposals = x.Proposals,
                    Taxes = x.Taxes
                })
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            return this.Ok(users);
        }
    }
}