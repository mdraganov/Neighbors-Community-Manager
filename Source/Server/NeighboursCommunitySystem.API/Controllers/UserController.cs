namespace NeighboursCommunitySystem.API.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Models.Users;
    using Data.DbContexts;

    public class UserController : ApiController
    {
        public IHttpActionResult GetAll()
        {
            var db = new NeighboursCommunityDbContext();

            var users = db.Users
                .Select(x => new UserDetailedResponseModel()
                {
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    AppartmentNumber = x.AppartmentNumber,
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