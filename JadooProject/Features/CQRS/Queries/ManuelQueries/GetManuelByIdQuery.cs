namespace JadooProject.Features.CQRS.Queries.ManuelQueries
{
    public class GetManuelByIdQuery
    {
        public int ID { get; set; }

        public GetManuelByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
