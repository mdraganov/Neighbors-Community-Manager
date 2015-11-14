namespace NeighboursCommunitySystem.API.Controllers
{
    using System.Linq;
    using System.Web;
    using System.Web.Http;
    using Services.Data.Contracts;
    using DtoModels.Communities;
    using Models;
    using Common;
    using DtoModels.Taxes;

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

        [Authorize(Roles = "DbAdmin")]
        public IHttpActionResult Get()
        {
            var allTaxes = taxes.All().Select(t => new TaxDataTransferModel
            {
                Name = t.Name,
                Description = t.Description,
                Deadline = t.Deadline,
                Price = t.Price
            })
            .ToList();

            return this.Ok(allTaxes);
        }

        [Authorize(Roles = "DbAdmin,Administrator,Accountant")]
        public IHttpActionResult Get(int communityId)
        {
            var communityTaxes = taxes.GetByCommunityId(communityId).Select(t => new TaxDataTransferModel
            {
                Name = t.Name,
                Description = t.Description,
                Deadline = t.Deadline,
                Price = t.Price
            })
            .ToList();

            return this.Ok(communityTaxes);
        }

        [Authorize(Roles = "DbAdmin,Administrator")]
        public IHttpActionResult Post(int communityId)
        {
            var community = communities.GetById(communityId);


            return this.Ok();
        }
    }
}