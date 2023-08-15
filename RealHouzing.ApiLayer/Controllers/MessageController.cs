using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DtoLayer.MessageDtos;
using RealHouzing.EntityLayer.Concrete;

namespace RealHouzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _messageService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddMessage(AddMessageDto addMessageDto)
        {
            Message message = new Message()
            {
                Content = addMessageDto.Content,
                Email = addMessageDto.Email,
                Name = addMessageDto.Name,
                Phone = addMessageDto.Phone,
                Subject = addMessageDto.Subject

            };

            _messageService.TInsert(message);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var values = _messageService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            Message message = new Message()
            {
                MessageID = updateMessageDto.MessageID,
                Content = updateMessageDto.Content,
                Email = updateMessageDto.Email,
                Name = updateMessageDto.Name,
                Phone = updateMessageDto.Phone,
                Subject = updateMessageDto.Subject

            };
            _messageService.TUpdate(message);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var values = _messageService.TGetByID(id);
            _messageService.TDelete(values);
            return Ok();
        }
    }
}
