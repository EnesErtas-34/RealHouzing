using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.CategoriesDtos;
using RealHouzing.DtoLayer.ExploreDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesCategoriesController : ControllerBase
    {
        private readonly IServicesCategoriesService _servicesCategoriesService;

        public ServicesCategoriesController(IServicesCategoriesService servicesCategoriesService)
        {
            _servicesCategoriesService = servicesCategoriesService;
        }
        [HttpGet]
        public IActionResult ServicesCategoriesList()
        {
            var values = _servicesCategoriesService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteServicesCategories(int id)
        {
            var values = _servicesCategoriesService.TGetByID(id);
            _servicesCategoriesService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddServicesCategories(AddServicesCategoriesDto addServicesCategoriesDto)
        {
            ServicesCategories servicesCategories = new ServicesCategories()
            {
                Name = addServicesCategoriesDto.Name,
                Icon = addServicesCategoriesDto.Icon,
                Description = addServicesCategoriesDto.Description

            };
            _servicesCategoriesService.TInsert(servicesCategories);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateServicesCategories(UpdateServicesCategoriesDto updateServicesCategoriesDto)
        {
            ServicesCategories servicesCategories = new ServicesCategories()
            {
                Name = updateServicesCategoriesDto.Name,
                Icon = updateServicesCategoriesDto.Icon,
                Description = updateServicesCategoriesDto.Description

            };
            _servicesCategoriesService.TUpdate(servicesCategories);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetServicesCategories(int id)
        {
            var values = _servicesCategoriesService.TGetByID(id);
            return Ok(values);
        }
    }
}
