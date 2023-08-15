using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.CategoriesModels;

namespace RealHouzing.Consume.ViewComponents.Services
{
    public class _ServicesCategories:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ServicesCategories(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/ServicesCategories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ServicesCategoriesListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
