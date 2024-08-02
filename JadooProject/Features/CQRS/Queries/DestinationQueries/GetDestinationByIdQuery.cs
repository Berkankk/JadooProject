namespace JadooProject.Features.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIdQuery
    {
        public int ID { get; set; }

        public GetDestinationByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
