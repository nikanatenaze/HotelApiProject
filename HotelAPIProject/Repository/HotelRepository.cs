using HotelAPIProject.Data;
using HotelAPIProject.Models;

namespace HotelAPIProject.Repository
{
    public class HotelRepository : HotelSystemRepository<Hotel>, IHotelRepository
    {
        public HotelRepository(DataContext data) : base(data)
        {
        }
    }
}
