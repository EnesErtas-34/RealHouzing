﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.ServiceModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _DefaultServices:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultServices(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/Service/");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<ServiceListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
