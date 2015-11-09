namespace NeighboursCommunitySystem.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Invitation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required]
        [MinLength(36, ErrorMessage = "The verification token cannot have length less than 32 characters")]
        [MaxLength(40, ErrorMessage = "The verification token cannot have length greater than 40 characters")]
        public string VerificationToken { get; set; }
    }
}