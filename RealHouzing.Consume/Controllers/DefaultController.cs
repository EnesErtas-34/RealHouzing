using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.AboutUsVideoModels;
using RealHouzing.Consume.Models.SubscribeModels;
using System.Text;

namespace RealHouzing.Consume.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult Subscribe()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe(AddSubscribeViewModel addSubscribeViewModel)
        {
            var client=_httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(addSubscribeViewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44368/api/Subscribe",stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
