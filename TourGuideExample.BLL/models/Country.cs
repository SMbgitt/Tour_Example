namespace TourASP.models
{
    public class Country
    {
        public int Id { get; set; }
        public int ContinentId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int TimeZone{ get; set; }
        public string Weather { get; set; } = null!;
        public string Dish { get; set; } = null!;

    }
}
