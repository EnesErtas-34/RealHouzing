using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.AdminLayout
{
    public class _AdminLayoutHead:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
