namespace HotelAPIProject.Models
{
    public class BookingDTO
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int TotalPrice { get; set; }
        public DateTime BookingStarts { get; set; }
        public DateTime BookingEnds { get; set; }
    }
}
