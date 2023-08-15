using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutUsVideoDtos;
using RealHouzing.DtoLayer.PostPropertyDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostPropertyController : ControllerBase
    {
        private readonly IPostPropertyService _postPropertyService;

        public PostPropertyController(IPostPropertyService postPropertyService)
        {
            _postPropertyService = postPropertyService;
        }

        [HttpGet]
        public IActionResult PostPropertyList()
        {
            var values = _postPropertyService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePostProperty(int id)
        {
            var values = _postPropertyService.TGetByID(id);
            _postPropertyService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddPostProperty(AddPostPropertDto addPostPropertDto)
        {
            PostProperty postProperty = new PostProperty()
            {
                Title = addPostPropertDto.Title,
                Description = addPostPropertDto.Description,
                ImageURL = addPostPropertDto.ImageURL
            };
            _postPropertyService.TInsert(postProperty);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAboutUsVideo(UpdatePostPropertyDto updatePostPropertyDto)
        {
            PostProperty postProperty = new PostProperty()
            {
                PostPropertyID= updatePostPropertyDto.PostPropertyID,
                Title = updatePostPropertyDto.Title,
                Description = updatePostPropertyDto.Description,
                ImageURL = updatePostPropertyDto.ImageURL
            };
            _postPropertyService.TUpdate(postProperty);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutUsVideo(int id)
        {
            var values = _postPropertyService.TGetByID(id);
            return Ok(values);
        }
    }
}
