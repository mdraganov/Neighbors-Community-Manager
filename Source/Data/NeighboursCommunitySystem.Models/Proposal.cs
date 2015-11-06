namespace NeighboursCommunitySystem.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Proposal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public ushort Approvals { get; set; }

        [ForeignKey("Author")]
        public string AuthorID { get; set; }

        public virtual User Author { get; set; }

        // TODO: Add "IsApproved" property that is not mapped to the database and returns TRUE if more than 75% of all users had voted "YES" for the proposal.
    }
}