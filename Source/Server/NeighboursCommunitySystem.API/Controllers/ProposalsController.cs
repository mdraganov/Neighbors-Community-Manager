namespace NeighboursCommunitySystem.API.Controllers
{
    using NeighboursCommunitySystem.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class ProposalsController : BaseApiController
    {
        public ProposalsController(IProposalService proposalsService)
            : base(proposalsService)
        {
        }

        public IHttpActionResult Get()
        {
            var result = this.proposalsService
                .All()
                .ToList();

            return this.Ok(result);
        }
    }
}
