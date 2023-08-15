namespace RealHouzing.Consume.Models.AboutFeatureModels
{
    public class UpdateAboutFeatureViewModel
    {
        public int AboutFeatureID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string Features { get; set; }
        public string? ImageURL { get; set; }
    }
}
