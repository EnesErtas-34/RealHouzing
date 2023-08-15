using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.AboutUsVideoModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _DefaultAboutUsVideo:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultAboutUsVideo(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/AboutUsVideo");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<AboutUsVideoListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
