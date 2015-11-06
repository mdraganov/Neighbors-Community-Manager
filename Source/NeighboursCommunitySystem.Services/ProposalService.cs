namespace NeighboursCommunitySystem.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NeighboursCommunitySystem.Data.Repositories;
    using NeighboursCommunitySystem.Models;

    public class ProposalService : IProposalService
    {
        private readonly IRepository<Proposal> proposals;

        public ProposalService(IRepository<Proposal> proposals)
        {
            this.proposals = proposals;
        }

        public IQueryable<Proposal> All()
        {
            return this.proposals
                .All()
                .OrderBy(p => p.Approvals);
        }

        //TODO: Get by author, 

        //TODO: Post
    }
}
