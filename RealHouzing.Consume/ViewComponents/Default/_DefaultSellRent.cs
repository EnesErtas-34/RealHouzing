using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.SellRentModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _DefaultSellRent:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultSellRent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/SellRent");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values= JsonConvert.DeserializeObject<List<SellRentListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
