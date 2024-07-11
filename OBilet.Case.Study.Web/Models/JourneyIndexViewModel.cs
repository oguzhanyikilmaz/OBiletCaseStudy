namespace OBilet.Case.Study.Web.Models
{
    public class JourneyIndexViewModel
    {
        public string Origin { get; set; }
        public string OriginLocation { get; set; }
        public string Destination { get; set; }
        public string DestinationLocation { get; set; }
        public string DepartureDate { get; set; }
        public List<Journey> Journeys { get; set; }
    }

    public class Journey
    {
        public string Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string BusCompany { get; set; }
        public string Price { get; set; }
    }
}
