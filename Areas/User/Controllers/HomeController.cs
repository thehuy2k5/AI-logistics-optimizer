using Microsoft.AspNetCore.Mvc;

namespace AI_logistics_optimizer.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrder()
        {
            return View();
        }

        public IActionResult TrackOrder()
        {
            return View();
        }

        public IActionResult OrderHistory()
        {
            return View();
        }
    }
}