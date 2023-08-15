using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Services
{
    public class _ServicesBanner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
