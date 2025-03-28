using Microsoft.AspNetCore.Mvc;

namespace HotelAPIProject.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Test()
        {
            return Ok();
        }
    }
}
