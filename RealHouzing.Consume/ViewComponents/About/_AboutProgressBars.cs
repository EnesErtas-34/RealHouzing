using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.ProgressBarModels;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _AboutProgressBars:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutProgressBars(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/ProgressBar");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ProgressBarListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
