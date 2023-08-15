using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutFeatureDtos;
using RealHouzing.DtoLayer.ExploreDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExploreController : ControllerBase
    {
        private readonly IExploreService _exploreService;

        public ExploreController(IExploreService exploreService)
        {
            _exploreService = exploreService;
        }
        [HttpGet]
        public IActionResult ExploreList()
        {
            var values = _exploreService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteExplore(int id)
        {
            var values = _exploreService.TGetByID(id);
            _exploreService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddExplore(AddExploreDto addExploreDto)
        {
            Explore explore = new Explore()
            {
                ExploreName = addExploreDto.ExploreName,
                Icon = addExploreDto.Icon,
                ImageURL = addExploreDto.ImageURL
                
            };
            _exploreService.TInsert(explore);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateExplore(UpdateExploreDto updateExploreDto)
        {
            Explore explore = new Explore()
            {
                ExploreID = updateExploreDto.ExploreID,
                ExploreName = updateExploreDto.ExploreName,
                Icon = updateExploreDto.Icon,
                ImageURL = updateExploreDto.ImageURL

            };
            _exploreService.TUpdate(explore);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetExplore(int id)
        {
            var values = _exploreService.TGetByID(id);
            return Ok(values);
        }
    }
}
