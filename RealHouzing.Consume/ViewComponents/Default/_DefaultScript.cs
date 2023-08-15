using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _DefaultScript:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
