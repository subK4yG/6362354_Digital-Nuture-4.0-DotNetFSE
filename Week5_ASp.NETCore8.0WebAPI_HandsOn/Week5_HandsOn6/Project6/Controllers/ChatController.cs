using Microsoft.AspNetCore.Mvc;
using Project6.Kafka;
using Project6.Models;

namespace Project6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly KafkaProducer _producer;

        public ChatController(IConfiguration config)
        {
            _producer = new KafkaProducer(config);
        }

        [HttpPost("send")]
        public async Task<IActionResult> Send([FromBody] ChatMessage msg)
        {
            msg.Timestamp = DateTime.UtcNow;
            await _producer.SendMessageAsync(msg);
            return Ok("Message sent to Kafka");
        }

        [HttpGet("receive")]
        public async Task<ActionResult<List<ChatMessage>>> Receive()
        {
            var consumer = new KafkaConsumer();
            var messages = await consumer.ConsumeMessagesAsync();
            return Ok(messages);
        }
    }
}
