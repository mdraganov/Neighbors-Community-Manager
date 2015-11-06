namespace NeighboursCommunitySystem.API.Models.Users
{
    using NeighboursCommunitySystem.Models;
    using System.Collections.Generic;

    public class UserDetailedResponseModel
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte ApartmentNumber { get; set; }

        public IEnumerable<Tax> Taxes { get; set; }

        public IEnumerable<Proposal> Proposals { get; set; }
    }
}