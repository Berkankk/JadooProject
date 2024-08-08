namespace JadooProject.Features.CQRS.Queries.BrandQueries
{
    public class GetBrandByIdQuery
    {
        public int ID { get; set; }

        public GetBrandByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
