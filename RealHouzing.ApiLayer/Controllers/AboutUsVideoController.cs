using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutUsVideoDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsVideoController : ControllerBase
    {
        private readonly IAboutUsVideoService _aboutUsVideoService;

        public AboutUsVideoController(IAboutUsVideoService aboutUsVideoService)
        {
            _aboutUsVideoService = aboutUsVideoService;
        }
        [HttpGet]
        public IActionResult AboutUsVideoList() 
        { 
            var values=_aboutUsVideoService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAboutUsVideo(int id)
        {
            var values=_aboutUsVideoService.TGetByID(id);
            _aboutUsVideoService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddAboutUsVideo(AddAboutUsVideoDto addAboutUsVideoDto)
        {
            AboutUsVideo aboutUsVideo = new AboutUsVideo()
            {
                VideoURL = addAboutUsVideoDto.VideoURL,
                Title = addAboutUsVideoDto.Title,
                Description = addAboutUsVideoDto.Description
            };
            _aboutUsVideoService.TInsert(aboutUsVideo);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAboutUsVideo(UpdateAboutUsVideoDto updateAboutUsVideoDto)
        {
            AboutUsVideo aboutUsVideo = new AboutUsVideo()
            {
                AboutUsVideoID = updateAboutUsVideoDto.AboutUsVideoID,
                VideoURL = updateAboutUsVideoDto.VideoURL,
                Title = updateAboutUsVideoDto.Title,
                Description = updateAboutUsVideoDto.Description
            };
            _aboutUsVideoService.TUpdate(aboutUsVideo);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutUsVideo(int id)
        {
            var values=_aboutUsVideoService.TGetByID(id);
            return Ok(values);
        }
    }
}
