using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutUsVideoDtos;
using RealHouzing.DtoLayer.TestimonialDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddTestimonial(AddTestimonialDto addTestimonialDto)
        {
            Testimonial testimonial = new Testimonial()
            {
                NameSurname=addTestimonialDto.NameSurname,
                Title = addTestimonialDto.Title,
                Comment = addTestimonialDto.Comment,
                ImageURL = addTestimonialDto.ImageURL
            };
            _testimonialService.TInsert(testimonial);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            Testimonial testimonial = new Testimonial()
            {
                TestimonialID= updateTestimonialDto.TestimonialID,
                NameSurname = updateTestimonialDto.NameSurname,
                Title = updateTestimonialDto.Title,
                Comment = updateTestimonialDto.Comment,
                ImageURL = updateTestimonialDto.ImageURL
            };
            _testimonialService.TUpdate(testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var values = _testimonialService.TGetByID(id);
            return Ok(values);
        }
    }
}
