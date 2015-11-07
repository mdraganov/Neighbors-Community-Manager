namespace NeighboursCommunitySystem.Models
{
    public class ApprovableUser
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public int ProposalId { get; set; }

        public virtual Proposal Proposal { get; set; }
    }
}
