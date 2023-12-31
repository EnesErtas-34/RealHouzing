﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.MyTeamModels;

namespace RealHouzing.Consume.ViewComponents.About
{
    public class _AboutTeam:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutTeam(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/MyTeam");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<MyTeamListViewModel>>(jsonData);
                return View(values);
            }
            return View();

        }
    }
}
