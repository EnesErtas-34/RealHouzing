using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutFeatureDtos;
using RealHouzing.DtoLayer.ServicesPostPropertyDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesPostPropertyController : ControllerBase
    {
        private readonly IServicesPostPropertyService _servicesPostPropertyService;

        public ServicesPostPropertyController(IServicesPostPropertyService servicesPostPropertyService)
        {
            _servicesPostPropertyService = servicesPostPropertyService;
        }
        [HttpGet]
        public IActionResult ServicesPostPropertyList()
        {
            var values = _servicesPostPropertyService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteServicesPostProperty(int id)
        {
            var values = _servicesPostPropertyService.TGetByID(id);
            _servicesPostPropertyService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddServicesPostProperty(AddServicesPostPropertyDto addServicesPostPropertyDto)
        {
            ServicesPostProperty servicesPostProperty = new ServicesPostProperty()
            {
                Title = addServicesPostPropertyDto.Title,
                Description = addServicesPostPropertyDto.Description,
                ImageURL = addServicesPostPropertyDto.ImageURL
               
            };
            _servicesPostPropertyService.TInsert(servicesPostProperty);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateServicesPostProperty(UpdateServicesPostPropertyDto updateServicesPostPropertyDto)
        {
            ServicesPostProperty servicesPostProperty = new ServicesPostProperty()
            {
                ServicesPostPropertyID = updateServicesPostPropertyDto.ServicesPostPropertyID,
                Title = updateServicesPostPropertyDto.Title,
                Description = updateServicesPostPropertyDto.Description,
                ImageURL = updateServicesPostPropertyDto.ImageURL

            };
            _servicesPostPropertyService.TUpdate(servicesPostProperty);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutFeature(int id)
        {
            var values = _servicesPostPropertyService.TGetByID(id);
            return Ok(values);
        }
    }
}
