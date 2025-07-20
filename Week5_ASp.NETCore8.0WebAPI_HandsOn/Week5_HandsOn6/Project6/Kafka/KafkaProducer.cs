using Confluent.Kafka;
using System.Text.Json;
using Project6.Models;

namespace Project6.Kafka
{
    public class KafkaProducer
    {
        private readonly IConfiguration _configuration;

        public KafkaProducer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendMessageAsync(ChatMessage message)
        {
            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

            using var producer = new ProducerBuilder<Null, string>(config).Build();
            var jsonMessage = JsonSerializer.Serialize(message);
            await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = jsonMessage });
        }
    }
}
