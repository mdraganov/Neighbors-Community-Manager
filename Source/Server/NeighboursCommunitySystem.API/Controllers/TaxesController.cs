namespace NeighboursCommunitySystem.API.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Services.Data.Contracts;
    using DtoModels.Taxes;
    using AutoMapper.QueryableExtensions;

    public class TaxesController : ApiController
    {
        private readonly ITaxesService taxes;

        public TaxesController(ITaxesService taxes)
        {
            this.taxes = taxes;
        }

        [Authorize(Roles = "DbAdmin")]
        public IHttpActionResult Get()
        {
            var allTaxes = taxes.All().ProjectTo<TaxDataTransferModel>().ToList();

            return this.Ok(allTaxes);
        }

        [Authorize(Roles = "DbAdmin,Administrator,Accountant")]
        public IHttpActionResult Get(int communityId)
        {
            var communityTaxes = taxes
                                .GetByCommunityId(communityId)
                                .ProjectTo<TaxDataTransferModel>()
                                .ToList();

            return this.Ok(communityTaxes);
        }

        [Authorize(Roles = "DbAdmin,Administrator")]
        public IHttpActionResult Post(int communityId, TaxDataTransferModel model)
        {
            int taxId = taxes.AddByCommunityId(communityId, model);

            return this.Ok(taxId);
        }
    }
}