using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Services
{
    public class _ServicesPricing:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
