namespace NeighboursCommunitySystem.API.Controllers
{
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Web.Http.Description;
    using Models;
    using Services.Data.Contracts;

    public class ProposalsController : ApiController
    {
        private readonly IProposalService proposalService;

        public ProposalsController(IProposalService proposalService)
        {
            this.proposalService = proposalService;
        }

        [HttpGet]
        [ResponseType(typeof(IQueryable<Proposal>))]
        public async Task<IHttpActionResult> Get()
        {
            var model = await this.proposalService.All().ToListAsync();
            return this.Ok(model);
        }

    }
}