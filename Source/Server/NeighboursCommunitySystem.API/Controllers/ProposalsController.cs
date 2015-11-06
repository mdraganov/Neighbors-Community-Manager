namespace NeighboursCommunitySystem.API.Controllers
{
    using System.Data.Entity;
    using System.Threading.Tasks;
    using System.Web.Http;
    using Services.Data.Contracts;

    public class ProposalsController : ApiController
    {
        private readonly IProposalsService proposalService;

        public ProposalsController(IProposalsService proposalService)
        {
            this.proposalService = proposalService;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var model = await this.proposalService.All().ToListAsync();
            return this.Ok(model);
        }

    }
}
