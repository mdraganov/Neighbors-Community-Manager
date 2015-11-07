namespace NeighboursCommunitySystem.DtoModels.Proposals

{
    using NeighboursCommunitySystem.Models;

    public class ProposalDetailedResponseModel
    {
        public User Author { get; set; }

        public string Description { get; set; }

        public ushort Approvals { get; set; }
    }
}