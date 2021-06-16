using WongaLibrary.Utilities;

namespace WongaLibrary.Components
{
    public class MessageComponent : IMessageComponent
    {
        IRabbitMqService _rabbitMqService;

        public MessageComponent(IRabbitMqService rabbitMqService)
        {
            _rabbitMqService = rabbitMqService;
        }

        public void SendMessage(string message, string queue)
        {
            _rabbitMqService.SendData(message, queue);
        }

        public string GetMessage(string queue)
        {
            return _rabbitMqService.GetData(queue);
        }
    }
}
