﻿namespace JadooProject.Features.CQRS.Results.TestimonialResults
{
    public class GetTestimonialForDashboardQueryResult
    {
        public int TestimonialID { get; set; }
        public string ImageUrl { get; set; }
   
        public string NameSurname { get; set; }
        public string Country { get; set; }
    }
}
