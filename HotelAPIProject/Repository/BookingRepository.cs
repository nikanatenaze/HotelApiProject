using HotelAPIProject.Data;
using HotelAPIProject.Models;

namespace HotelAPIProject.Repository
{
    public class BookingRepository : HotelSystemRepository<Booking>, IBookingRepository
    {
        public BookingRepository(DataContext data) : base(data)
        {
        }
    }
}
