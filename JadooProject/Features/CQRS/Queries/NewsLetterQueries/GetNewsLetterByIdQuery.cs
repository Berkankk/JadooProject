namespace JadooProject.Features.CQRS.Queries.NewsLetterQueries
{
    public class GetNewsLetterByIdQuery
    {
        public int ID { get; set; }

        public GetNewsLetterByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
