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
        [MaxLength(150, ErrorMessage = "Email length cannot exceed 150 characters.{0}")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required]
        [MaxLength(8000)]
        public byte[] VerificationToken { get; set; }

        [Required]
        [MaxLength(8000)]
        public byte[] DecryptionKey { get; set; }

        [Required]
        [MaxLength(8000)]
        public byte[] InitializationVector { get; set; }
    }
}