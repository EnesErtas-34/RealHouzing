using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.ExploreModels;

namespace RealHouzing.Consume.ViewComponents.Services
{
    public class _ServicesExplore:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ServicesExplore(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/Explore");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ExploreListViewModel>>(jsonData);
                return View(values);
            }
            return View();
            
        }
    }
}
