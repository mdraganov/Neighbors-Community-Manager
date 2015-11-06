namespace NeighboursCommunitySystem.Services.Data
{
    using Contracts;
    using NeighboursCommunitySystem.Data.Repositories;
    using System.Linq;
    using Models;

    public class ProposalService : IProposalsService
    {
        private readonly IRepository<Proposal> proposals;

        public ProposalService(IRepository<Proposal> proposals)
        {
            this.proposals = proposals;
        }

        public IQueryable<Proposal> All()
        {
            return this.proposals.All().AsQueryable();
        }
    }
}
