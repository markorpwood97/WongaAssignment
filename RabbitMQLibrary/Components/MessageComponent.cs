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

        public void SendMessage(string message)
        {
            _rabbitMqService.SendData(message);
        }

        public string GetMessage()
        {
            return _rabbitMqService.GetData();
        }
    }
}
