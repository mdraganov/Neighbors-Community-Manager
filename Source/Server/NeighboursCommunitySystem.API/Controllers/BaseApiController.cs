namespace NeighboursCommunitySystem.API.Controllers
{
    using Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Http;

    public class BaseApiController : ApiController
    {
        protected readonly IProposalService proposalsService;

        public BaseApiController(IProposalService proposalsService)
        {
            this.proposalsService = proposalsService;
        }
    }
}