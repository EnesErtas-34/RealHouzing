﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.FeatureModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _DefaultFeature:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultFeature(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/Feature"); 
            if (responseMessage.IsSuccessStatusCode) 
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FeatureListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
