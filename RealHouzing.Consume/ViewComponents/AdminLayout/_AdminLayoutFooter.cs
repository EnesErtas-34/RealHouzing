using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.AdminLayout
{
    public class _AdminLayoutFooter:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
