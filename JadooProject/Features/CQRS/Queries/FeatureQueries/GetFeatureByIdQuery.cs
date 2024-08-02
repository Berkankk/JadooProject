namespace JadooProject.Features.CQRS.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery
    {
        public int ID { get; set; }

        public GetFeatureByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
