namespace TourASP.models
{
    public class Fact
    {
        public int Id { get; set; }
        public int CountryID { get; set; }
        public string FactText { get; set; } = null!;
    }
}
