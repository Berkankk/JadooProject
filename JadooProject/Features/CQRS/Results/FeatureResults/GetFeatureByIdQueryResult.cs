namespace JadooProject.Features.CQRS.Results.FeatureResults
{
    public class GetFeatureByIdQueryResult
    {
        public int FeatureID { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public string LowerDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}
