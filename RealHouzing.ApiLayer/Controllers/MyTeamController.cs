using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.AboutFeatureDtos;
using RealHouzing.DtoLayer.MyTeamDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyTeamController : ControllerBase
    {
        private readonly IMyTeamService _myTeamService;

        public MyTeamController(IMyTeamService myTeamService)
        {
            _myTeamService = myTeamService;
        }
        [HttpGet]
        public IActionResult AboutFeatureList()
        {
            var values = _myTeamService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAboutFeature(int id)
        {
            var values = _myTeamService.TGetByID(id);
            _myTeamService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddAboutFeature(AddMyTeamDto addMyTeamDto)
        {
            MyTeam myTeam = new MyTeam()
            {
                NameSurname=addMyTeamDto.NameSurname,
                Job=addMyTeamDto.Job,
                ImageURL=addMyTeamDto.ImageURL,
                Facebook=addMyTeamDto.Facebook,
                Twitter=addMyTeamDto.Twitter,
                Linkedin=addMyTeamDto.Linkedin
            };
            _myTeamService.TInsert(myTeam);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAboutFeature(UpdateMyTeamDto updateMyTeamDto)
        {
            MyTeam myTeam = new MyTeam()
            {
                MyTeamID = updateMyTeamDto.MyTeamID,
                NameSurname = updateMyTeamDto.NameSurname,
                Job = updateMyTeamDto.Job,
                ImageURL = updateMyTeamDto.ImageURL,
                Facebook = updateMyTeamDto.Facebook,
                Twitter = updateMyTeamDto.Twitter,
                Linkedin = updateMyTeamDto.Linkedin
            };
            _myTeamService.TUpdate(myTeam);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutFeature(int id)
        {
            var values = _myTeamService.TGetByID(id);
            return Ok(values);
        }
    }
}
