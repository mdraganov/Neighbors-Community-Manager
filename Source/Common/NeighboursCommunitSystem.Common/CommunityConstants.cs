namespace NeighboursCommunitySystem.Common
{
    public static class CommunityConstants
    {
        public const int CommunityNameLengthMin = 3;
        public const int CommunityNameLengthMax = 30;
        public const string ShortNameErrorMessage = "Community name length should be equal to or more than 3 characters.";
        public const string LongtNameErrorMessage = "Community name length should be equal to or shorter than 30 characters.";

        public const int DescriptionLengthMin = 3;
        public const int DescriptionLengthMax = 300;
        public const string ShortDescriptionErrorMessage = "Community description should be at least 3 characters long.";
        public const string LongDescriptionErrorMessage = "Community description should be no more than 300 characters long.";
    }
}
