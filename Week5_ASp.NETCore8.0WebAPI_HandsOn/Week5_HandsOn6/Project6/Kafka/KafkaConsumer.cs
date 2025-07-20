using Confluent.Kafka;
using Project6.Models;
using System.Text.Json;

namespace Project6.Kafka
{
    public class KafkaConsumer
    {
        public async Task<List<ChatMessage>> ConsumeMessagesAsync(int count = 10)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "chat-consumer-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe("chat-topic");

            var messages = new List<ChatMessage>();

            try
            {
                for (int i = 0; i < count; i++)
                {
                    var result = consumer.Consume(TimeSpan.FromSeconds(1));
                    if (result != null)
                    {
                        var message = JsonSerializer.Deserialize<ChatMessage>(result.Message.Value);
                        messages.Add(message);
                    }
                }
            }
            finally
            {
                consumer.Close();
            }

            return messages;
        }
    }
}
