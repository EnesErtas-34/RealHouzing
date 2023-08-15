using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.PostPropertyModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _DefaultPostProperty:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultPostProperty(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        { 
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/PostProperty");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<PostPropertyListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }

    }
}
