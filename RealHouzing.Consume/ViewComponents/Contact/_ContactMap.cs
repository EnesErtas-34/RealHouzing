using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Contact
{
    public class _ContactMap:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
