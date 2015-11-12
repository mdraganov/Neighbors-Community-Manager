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
        private readonly int currentCommunityId;

        public TaxesController(ITaxesService taxes)
        {
            this.taxes = taxes;
            // this.currentCommunityId = ;
        }

        [Authorize(Roles = "Administrator,Accountant")]
        public IHttpActionResult Get()
        {
            var result = taxes.GetByCommunityId(currentCommunityId);

            return this.Ok(result);
        }
    }
}