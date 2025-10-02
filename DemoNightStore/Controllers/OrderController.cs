using Microsoft.AspNetCore.Mvc;

namespace DemoNightStore.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Statistics()
        {
            return View();
        }
    }
}
