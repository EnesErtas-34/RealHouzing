using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutUsVideoDtos;
using RealHouzing.DtoLayer.BlogDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        [HttpGet]
        public IActionResult BlogList()
        {
            var values = _blogService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBlog(int id)
        {
            var values = _blogService.TGetByID(id);
            _blogService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddBlog(AddBlogDto addBlogDto)
        {
            Blog blog = new Blog()
            {
                Title = addBlogDto.Title,
                Description = addBlogDto.Description,
                BlogImage = addBlogDto.BlogImage,
                Writer = addBlogDto.Writer,
                WriterImage = addBlogDto.WriterImage,
                Date = addBlogDto.Date,
            };
            _blogService.TInsert(blog);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBlog(UpdateBlogDto updateBlogDto)
        {
            Blog blog = new Blog()
            {
                BlogID = updateBlogDto.BlogID,
                Title = updateBlogDto.Title,
                Description = updateBlogDto.Description,
                BlogImage = updateBlogDto.BlogImage,
                Writer = updateBlogDto.Writer,
                WriterImage = updateBlogDto.WriterImage,
                Date = updateBlogDto.Date,
            };
            _blogService.TUpdate(blog);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutUsVideo(int id)
        {
            var values = _blogService.TGetByID(id);
            return Ok(values);
        }
    }
}
