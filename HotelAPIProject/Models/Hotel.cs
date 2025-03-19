namespace HotelAPIProject.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
