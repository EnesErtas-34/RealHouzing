using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.FeatureDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            var values=_featureService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFeature(int id)
        {
            var values=_featureService.TGetByID(id);
            _featureService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddFeature(AddFeatureDto addFeatureDto)
        {
            Feature feature = new Feature()
            {
                FeatureTitle = addFeatureDto.FeatureTitle,
                FeatureSubTitle = addFeatureDto.FeatureSubTitle,
                ImageURL = addFeatureDto.ImageURL
            };
            _featureService.TInsert(feature);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            Feature feature = new Feature()
            {
                FeatureID = updateFeatureDto.FeatureID,
                FeatureTitle = updateFeatureDto.FeatureTitle,
                ImageURL = updateFeatureDto.ImageURL,
                FeatureSubTitle = updateFeatureDto.FeatureSubTitle

            };
            _featureService.TUpdate(feature);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {
            var values = _featureService.TGetByID(id);
            return Ok(values);
        }
    }
}
