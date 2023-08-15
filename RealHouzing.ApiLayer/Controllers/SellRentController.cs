using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.SellRentDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellRentController : ControllerBase
    {
        private readonly ISellRentService _sellRentService;

        public SellRentController(ISellRentService sellRentService)
        {
            _sellRentService = sellRentService;
        }
        [HttpGet]
        public IActionResult SellRentList()
        {
            var values=_sellRentService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSellRent(int id) 
        { 
            var values=_sellRentService.TGetByID(id);
            _sellRentService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddSellRent(AddSellRentDto addSellRentDto)
        {
            SellRent sellRent = new SellRent()
            {
                Title = addSellRentDto.Title,
                Title2 = addSellRentDto.Title2,
                ImageURL = addSellRentDto.ImageURL,
                Button = addSellRentDto.Button
            };
            _sellRentService.TInsert(sellRent);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSellRent(UpdateSellRentDto updateSellRentDto)
        {
            SellRent sellRent = new SellRent()
            {
                SellRentID= updateSellRentDto.SellRentID,
                Title = updateSellRentDto.Title,
                Title2 = updateSellRentDto.Title2,
                ImageURL = updateSellRentDto.ImageURL,
                Button = updateSellRentDto.Button
            };
            _sellRentService.TUpdate(sellRent);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var values = _sellRentService.TGetByID(id);
            return Ok(values);
        }
    }
}
