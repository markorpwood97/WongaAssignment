namespace WongaLibrary.Utilities
{
    public interface IRabbitMqService
    {
        void SendData(string message, string queue);
        string GetData(string queue);

    }
}
