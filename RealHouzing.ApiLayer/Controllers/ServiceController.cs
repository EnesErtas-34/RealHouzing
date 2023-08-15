using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutUsVideoDtos;
using RealHouzing.DtoLayer.ServiceDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetByID(id);
            _serviceService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddAboutUsVideo(AddServiceDto addServiceDto)
        {
            Service service = new Service()
            {
                Title = addServiceDto.Title,
                Icon=addServiceDto.Icon,
                ServiceName=addServiceDto.ServiceName,
                Description = addServiceDto.Description
            };
            _serviceService.TInsert(service);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAboutUsVideo(UpdateServiceDto updateServiceDto)
        {
            Service service = new Service()
            {
                ServiceID=updateServiceDto.ServiceID,
                Title = updateServiceDto.Title,
                Icon = updateServiceDto.Icon,
                ServiceName = updateServiceDto.ServiceName,
                Description = updateServiceDto.Description
            };
            _serviceService.TUpdate(service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutUsVideo(int id)
        {
            var values = _serviceService.TGetByID(id);
            return Ok(values);
        }
    }
}
