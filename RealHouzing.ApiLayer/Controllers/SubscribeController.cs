using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutUsVideoDtos;
using RealHouzing.DtoLayer.SubscribeDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }
        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            _subscribeService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddSubscribe(AddSubscribeDto addSubscribeDto)
        {
            Subscribe subscribe = new Subscribe()
            {
              Mail= addSubscribeDto.Mail
            };
            _subscribeService.TInsert(subscribe);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(UpdateSubscribeDto updateSubscribeDto)
        {
            Subscribe subscribe = new Subscribe()
            {
                SubscribeID = updateSubscribeDto.SubscribeID,
                Mail= updateSubscribeDto.Mail
            };
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutUsVideo(int id)
        {
            var values = _subscribeService.TGetByID(id);
            return Ok(values);
        }
    }
}
