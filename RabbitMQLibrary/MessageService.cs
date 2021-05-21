using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace WongaLibrary
{
    public class MessageService
    {
        public static void Send(string queue, string message)
        {
            ConnectionFactory factory = new ConnectionFactory() { HostName = "localhost" };

            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare(queue: queue,
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);

            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "",
                                 routingKey: queue,
                                 basicProperties: null,
                                 body: body);
        }

        public static void Get(string queue)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare(queue: queue,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);

                message = GreetingComponent.RemoveInitalGreeting(message);

                if (!GreetingComponent.ValidateName(message))
                {
                    Console.WriteLine("The force is weak with this one");
                    return;
                }

                Console.WriteLine(GreetingComponent.AddIconicLine(message));
            };
            channel.BasicConsume(queue: queue,
                                 autoAck: true,
                                 consumer: consumer);

            Console.ReadLine();
        }
    }
}
