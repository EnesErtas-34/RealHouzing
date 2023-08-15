﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.OurFieldModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _DefaultOurFields:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultOurFields(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/OurField");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<OurFieldListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
