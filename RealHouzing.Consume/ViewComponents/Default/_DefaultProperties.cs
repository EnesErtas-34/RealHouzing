using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.ProductModels;
using RealHouzing.EntityLayer.Concrete;
using System.Net.Http;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _DefaultProperties:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultProperties(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/Product/ProductListWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ProductListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
