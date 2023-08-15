using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.ServicesPostPropertyModels;

namespace RealHouzing.Consume.ViewComponents.Services
{
    public class _ServicesPostProperty:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ServicesPostProperty(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/ServicesPostProperty");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ServicesPostPropertyListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
