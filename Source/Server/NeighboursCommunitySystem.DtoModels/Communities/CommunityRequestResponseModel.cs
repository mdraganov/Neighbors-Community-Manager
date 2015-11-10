namespace NeighboursCommunitySystem.DtoModels.Communities
{
    using System.ComponentModel.DataAnnotations;
    using Common;

    public class CommunityRequestResponseModel
    {
        [Required]
        [MinLength(CommunityConstants.CommunityNameLengthMin, ErrorMessage = CommunityConstants.ShortNameErrorMessage)]
        [MaxLength(CommunityConstants.CommunityNameLengthMin, ErrorMessage = CommunityConstants.LongtNameErrorMessage)]
        public string Name { get; set; }

        [MinLength(CommunityConstants.DescriptionLengthMin, ErrorMessage = CommunityConstants.ShortDescriptionErrorMessage)]
        [MaxLength(CommunityConstants.DescriptionLengthMax, ErrorMessage = CommunityConstants.LongDescriptionErrorMessage)]
        public string Description { get; set; }
    }
}
