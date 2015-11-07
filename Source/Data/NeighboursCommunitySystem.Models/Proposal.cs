namespace NeighboursCommunitySystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Proposal
    {
        private ICollection<ApprovableUser> usersApproved;

        public Proposal()
        {
            this.usersApproved = new HashSet<ApprovableUser>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        public int Approvals { get; set; }

        [ForeignKey("Author")]
        public string AuthorId { get; set; }

        public virtual User Author { get; set; }


        public virtual ICollection<ApprovableUser> UsersApproved
        {
            get { return this.usersApproved; }
            set { this.usersApproved = value; }
        }


        // TODO: Add "IsApproved" property that is not mapped to the database and returns TRUE if more than 75% of all users had voted "YES" for the proposal.
    }
}