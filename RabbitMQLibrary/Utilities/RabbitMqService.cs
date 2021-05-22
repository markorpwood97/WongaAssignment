using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace WongaLibrary.Utilities
{
    public class RabbitMqService : IRabbitMqService
    {
        ConnectionFactory _factory;
        string _queue;

        public RabbitMqService()
        {
            _factory = new ConnectionFactory() { HostName = "localhost" };
            _queue = "starwars";
        }

        public void SendData(string message)
        {
            using var connection = _factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare(queue: _queue,
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);

            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "",
                                 routingKey: _queue,
                                 basicProperties: null,
                                 body: body);
        }

        public string GetData()
        {
            string message = "";

            using var connection = _factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare(queue: _queue,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                message = Encoding.UTF8.GetString(body);
            };
            channel.BasicConsume(queue: _queue,
                                 autoAck: true,
                                 consumer: consumer);

            while (string.IsNullOrEmpty(message)) { }

            return message;
        }
    }
}
