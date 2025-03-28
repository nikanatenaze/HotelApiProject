using HotelAPIProject.Data;
using HotelAPIProject.Models;

namespace HotelAPIProject.Repository
{
    public class RoomRepository : HotelSystemRepository<Room>, IRoomRepository
    {
        public RoomRepository(DataContext data) : base(data)
        {
        }
    }
}
