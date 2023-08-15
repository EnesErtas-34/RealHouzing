using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Contact
{
    public class _ContactBanner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
