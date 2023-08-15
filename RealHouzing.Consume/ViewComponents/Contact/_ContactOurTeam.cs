using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.ContactModels;
using System.Net.Http;

namespace RealHouzing.Consume.ViewComponents.Contact
{
    public class _ContactOurTeam:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _ContactOurTeam(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ContactListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
