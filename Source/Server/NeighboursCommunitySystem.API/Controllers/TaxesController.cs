namespace NeighboursCommunitySystem.API.Controllers
{
    using System.Linq;
    using System.Web;
    using System.Web.Http;
    using Services.Data.Contracts;
    using DtoModels.Communities;
    using Models;
    using Common;

    public class TaxesController : ApiController
    {
        private readonly ITaxesService taxes;
        private readonly ICommunitiesService communities;
        private readonly int currentCommunityId;

        public TaxesController(ITaxesService taxes, ICommunitiesService communities)
        {
            this.taxes = taxes;
            this.communities = communities;
            // this.currentCommunityId = ;
        }

        [Authorize(Roles = "Administrator,Accountant")]
        public IHttpActionResult Get()
        {
            var result = taxes.GetByCommunityId(currentCommunityId);

            return this.Ok(result);
        }

        [Authorize(Roles = "Administrator")]
        public IHttpActionResult Post()
        {
            var community = communities.GetById(currentCommunityId);
            

            return this.Ok();
        }
    }
}