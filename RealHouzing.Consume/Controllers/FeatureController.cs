using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealHouzing.Consume.Models.FeatureModels;
using System.Net.Http;
using System.Text;

namespace RealHouzing.Consume.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FeatureController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();//burada istek oluşturma için
            var responseMessage = await client.GetAsync("https://localhost:44368/api/Feature");//burada api adresine istek 
            if (responseMessage.IsSuccessStatusCode) //200lü kodlar dönerse
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();//json datanın içerğini string formatta hazırlama
                var values = JsonConvert.DeserializeObject<List<FeatureListViewModel>>(jsonData);// jsondata deserialize edilecek değer, jsondatadan okunacak değer
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddFeature()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> AddFeature(AddFeatureViewModel addFeatureViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(addFeatureViewModel);//ekleme diye bu sefer serialize oldu ve gelen veri serilize oldu
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");//string dosyayı json formata çeviri 
            var responseMessage = await client.PostAsync("https://localhost:44368/api/Feature", stringContent);//ilk parametre istek yapacağın yer ikinci ise içeriği
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteFeature(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:44368/api/Feature/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateFeature(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44368/api/Feature/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateFeatureViewModel>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureViewModel updateFeatureViewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateFeatureViewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var respongeMessage = await client.PutAsync("https://localhost:44368/api/Feature/", stringContent);
            if (respongeMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
