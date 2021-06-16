using Autofac.Extras.Moq;
using Moq;
using WongaLibrary.Components;
using WongaLibrary.Utilities;
using Xunit;

namespace WongaMockTests
{
    public class MessageComponentTests
    {
        [Fact]
        public void SendMessage_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                string message = "test";
                string queue = "ConsoleB";

                mock.Mock<IRabbitMqService>()
                    .Setup(x => x.SendData(message, queue));

                var messageComponent = mock.Create<MessageComponent>();

                messageComponent.SendMessage(message, queue);

                mock.Mock<IRabbitMqService>()
                    .Verify(x => x.SendData(message, queue), Times.Exactly(1));
            }
        }

        [Fact]
        public void GetMessage_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                string message = "test";
                string queue = "ConsoleB";

                mock.Mock<IRabbitMqService>()
                    .Setup(x => x.GetData(queue))
                    .Returns(message);

                var messageComponent = mock.Create<MessageComponent>();
                var expected = message;

                var actual = messageComponent.GetMessage(queue);

                Assert.True(actual != null);
                Assert.Equal(expected, actual);
            }
        }
    }
}
