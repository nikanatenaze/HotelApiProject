namespace HotelAPIProject.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int Starts { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
