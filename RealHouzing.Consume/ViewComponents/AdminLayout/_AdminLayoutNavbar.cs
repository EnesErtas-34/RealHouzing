using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
