namespace OBilet.Case.Study.Web.Models
{
    public class JourneySearchViewModel
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DepartureDate { get; set; }
        public List<Location> Locations { get; set; }
    }

    public class Location
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
