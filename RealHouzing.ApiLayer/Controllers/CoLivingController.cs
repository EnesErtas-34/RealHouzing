using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutFeatureDtos;
using RealHouzing.DtoLayer.CoLivingDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoLivingController : ControllerBase
    {
        private readonly ICoLivingService _coLivingService;

        public CoLivingController(ICoLivingService coLivingService)
        {
            _coLivingService = coLivingService;
        }
        [HttpGet]
        public IActionResult CoLivingList()
        {
            var values = _coLivingService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCoLiving(int id)
        {
            var values = _coLivingService.TGetByID(id);
            _coLivingService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddCoLiving(AddCoLivingDto addCoLivingDto)
        {
            CoLiving coLiving = new CoLiving()
            {
                Title = addCoLivingDto.Title,
                Description = addCoLivingDto.Description,
                ImageURL1 = addCoLivingDto.ImageURL1,
                ImageURL2 = addCoLivingDto.ImageURL2
            };
            _coLivingService.TInsert(coLiving);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCoLiving(UpdateCoLivingDto updateCoLivingDto)
        {
            CoLiving coLiving = new CoLiving()
            {
                CoLivingID = updateCoLivingDto.CoLivingID,
                Title = updateCoLivingDto.Title,
                Description = updateCoLivingDto.Description,
                ImageURL1 = updateCoLivingDto.ImageURL1,
                ImageURL2 = updateCoLivingDto.ImageURL2
            };
            _coLivingService.TUpdate(coLiving);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutFeature(int id)
        {
            var values = _coLivingService.TGetByID(id);
            return Ok(values);
        }
    }
}
