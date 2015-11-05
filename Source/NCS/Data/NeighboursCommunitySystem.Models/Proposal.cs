namespace NeighboursCommunitySystem.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Proposal
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [ForeignKey("Author")]
        public string AuthorID { get; set; }

        public virtual User Author { get; set; }
    }
}