using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
