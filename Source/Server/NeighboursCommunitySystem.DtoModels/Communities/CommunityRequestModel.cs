namespace NeighboursCommunitySystem.DtoModels.Communities
{
    using System.ComponentModel.DataAnnotations;

    public class CommunityRequestModel
    {
        [Required]
        [MinLength(3, ErrorMessage = "Name cannot be shorthan then 3 characters.")]
        [MaxLength(30, ErrorMessage = "Name cannot be shorthan then 30 characters.")]
        public string Name { get; set; }

        [MinLength(3)]
        [MaxLength(300)]
        public string Description { get; set; }
    }
}
