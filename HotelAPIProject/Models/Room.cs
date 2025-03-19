namespace HotelAPIProject.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int Stars { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
