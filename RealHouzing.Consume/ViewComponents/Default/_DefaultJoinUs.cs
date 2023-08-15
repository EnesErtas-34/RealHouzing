using Microsoft.AspNetCore.Mvc;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _DefaultJoinUs:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
