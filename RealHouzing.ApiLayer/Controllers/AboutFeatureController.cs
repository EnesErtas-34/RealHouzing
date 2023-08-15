using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutFeatureDtos;
using RealHouzing.DtoLayer.AboutUsVideoDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutFeatureController : ControllerBase
    {
        private readonly IAboutFeatureService _aboutFeatureService;

        public AboutFeatureController(IAboutFeatureService aboutFeatureService)
        {
            _aboutFeatureService = aboutFeatureService;
        }
        [HttpGet]
        public IActionResult AboutFeatureList()
        {
            var values = _aboutFeatureService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAboutFeature(int id)
        {
            var values = _aboutFeatureService.TGetByID(id);
            _aboutFeatureService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddAboutFeature(AddAboutFeatureDto addAboutFeatureDto)
        {
            AboutFeature aboutFeature = new AboutFeature()
            {
                Title = addAboutFeatureDto.Title,
                Description = addAboutFeatureDto.Description,
                ImageURL = addAboutFeatureDto.ImageURL,
                Features = addAboutFeatureDto.Features
            };
            _aboutFeatureService.TInsert(aboutFeature);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAboutFeature(UpdateAboutFeatureDto updateAboutFeatureDto)
        {
            AboutFeature aboutFeature = new AboutFeature()
            {
                AboutFeatureID = updateAboutFeatureDto.AboutFeatureID,
                Title = updateAboutFeatureDto.Title,
                Description = updateAboutFeatureDto.Description,
                ImageURL = updateAboutFeatureDto.ImageURL,
                Features = updateAboutFeatureDto.Features
            };
            _aboutFeatureService.TUpdate(aboutFeature);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutFeature(int id)
        {
            var values = _aboutFeatureService.TGetByID(id);
            return Ok(values);
        }
    }
}
