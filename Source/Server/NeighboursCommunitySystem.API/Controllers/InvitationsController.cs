namespace NeighboursCommunitySystem.API.Controllers
{
    using Models;
    using Services.Data.Contracts;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Web.Http.Description;

    public class InvitationsController : ApiController
    {
        private readonly IInvitationService invitationService;

        public InvitationsController(IInvitationService invitationService)
        {
            this.invitationService = invitationService;
        }

        [HttpGet]
        [ResponseType(typeof(IQueryable<Invitation>))]
        public async Task<IHttpActionResult> Get()
        {
            var invitations = await this.invitationService.All().ToListAsync();
            return this.Ok(invitations);
        }


        // Route "api/invitations", METHOD(POST), ContentType:application/json, Body { "email@domain.com" }
        [HttpPost]
        public IHttpActionResult SendInvitation([FromBody]string email)
        {
            var response = this.invitationService.SendInvitation(email);
            return this.Ok(response);
        }
    }
}