namespace LifeManager.Core.Entities
{
    public class Location : BaseEntity
    {
        public string Title { get; set; } // "Ahmet'in evi"
        public string OpenAddress { get; set; }
        public string GoogleMapsLink { get; set; }
        public string Note { get; set; }
    }
}