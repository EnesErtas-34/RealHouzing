using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.OurFieldDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurFieldController : ControllerBase
    {
        private readonly IOurFieldService _ourFieldService;

        public OurFieldController(IOurFieldService ourFieldService)
        {
            _ourFieldService = ourFieldService;
        }
        [HttpGet]
        public IActionResult OurFieldList()
        {
            var values = _ourFieldService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteOurField(int id)
        {
            var values = _ourFieldService.TGetByID(id);
            _ourFieldService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddOurFields(AddOurFieldDto addOurFieldDto)
        {
            OurField ourField = new OurField()
            {
                Title = addOurFieldDto.Title,
                ImageURL = addOurFieldDto.ImageURL
            };
            _ourFieldService.TInsert(ourField);
            return Ok();

        }
        [HttpPut]
        public IActionResult UpdateOurField(UpdateOurFieldDto updateOurFieldDto)
        {
            OurField ourField = new OurField()
            {
                OurFieldID = updateOurFieldDto.OurFieldID,
                Title = updateOurFieldDto.Title,
                ImageURL = updateOurFieldDto.ImageURL
            };
            _ourFieldService.TUpdate(ourField);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetOurField(int id)
        {
            var values=_ourFieldService.TGetByID(id);
            return Ok(values);
        }
    }

    
}
