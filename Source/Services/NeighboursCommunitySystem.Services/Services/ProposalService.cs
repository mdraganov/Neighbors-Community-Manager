namespace NeighboursCommunitySystem.Services.Services
{
    using System.Linq;
    using Data.Repositories;
    using Models;
    using Contracts;

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
