namespace JadooProject.Features.CQRS.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery
    {
        public int ID { get; set; }

        public GetTestimonialByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
