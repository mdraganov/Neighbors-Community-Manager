namespace NeighboursCommunitySystem.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Http;
    using Services.Data.Contracts;
    using DtoModels.Communities;
    using Models;

    public class CommunitiesController : ApiController
    {
        private readonly ICommunitiesService communities;

        public CommunitiesController(ICommunitiesService communities)
        {
            this.communities = communities;
        }

        public IHttpActionResult Get()
        {
            var result = communities.All().ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Post(CommunityRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var newCommunityId = communities.Add(model.Name, model.Description);

            return this.Ok(newCommunityId);
        }
    }
}