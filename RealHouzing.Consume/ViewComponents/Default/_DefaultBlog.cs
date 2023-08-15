using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.BlogModels;

namespace RealHouzing.Consume.ViewComponents.Default
{
    public class _DefaultBlog:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

		public _DefaultBlog(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44368/api/Blog");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<BlogListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
