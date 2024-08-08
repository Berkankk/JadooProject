﻿namespace JadooProject.Features.CQRS.Results.DestinationResults
{
    public class GetDestinationHomeQueryResult
    {
        public int DestinationID { get; set; }

        public string ImageUrl { get; set; }

        public string City { get; set; }

        public string Duration { get; set; }

        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
