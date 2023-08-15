using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.CoLivingModels;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _AboutCoLiving:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutCoLiving(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/CoLiving");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<CoLivingListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
