using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.AdminLayout
{
    public class _AdminLayoutScript:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
