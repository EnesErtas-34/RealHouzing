using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.CoLivingDtos;
using RealHouzing.DtoLayer.ProgressBarDtos;
using RealHouzing.EntityLayer.Concrete;
using System.Runtime.CompilerServices;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgressBarController : ControllerBase
    {
        private readonly IProgressBarService _progressBarService;

        public ProgressBarController(IProgressBarService progressBarService)
        {
            _progressBarService = progressBarService;
        }
        [HttpGet]
        public IActionResult CoLivingList()
        {
            var values = _progressBarService.TGetList();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCoLiving(int id)
        {
            var values = _progressBarService.TGetByID(id);
            _progressBarService.TDelete(values);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddCoLiving(AddProgressBarDto addProgressBarDto)
        {
            ProgressBar progressBar=new ProgressBar()
            {
                Title = addProgressBarDto.Title,
                Description = addProgressBarDto.Description,
                Name = addProgressBarDto.Name,
                Value = addProgressBarDto.Value
            };
            _progressBarService.TInsert(progressBar);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCoLiving(UpdateProgressBarDto updateProgressBarDto)
        {
            ProgressBar progressBar = new ProgressBar()
            {
                ProgressBarID=updateProgressBarDto.ProgressBarID,
                Title = updateProgressBarDto.Title,
                Description = updateProgressBarDto.Description,
                Name = updateProgressBarDto.Name,
                Value = updateProgressBarDto.Value
            };
            _progressBarService.TUpdate(progressBar);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAboutFeature(int id)
        {
            var values = _progressBarService.TGetByID(id);
            return Ok(values);
        }
    }

}
