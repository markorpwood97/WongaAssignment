using Autofac.Extras.Moq;
using Moq;
using WongaLibrary;
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
                mock.Mock<IRabbitMqService>()
                    .Setup(x => x.SendData("test"));

                var cls = mock.Create<MessageComponent>();

                cls.SendMessage("test");

                Assert.True(0 == 0);

                mock.Mock<IRabbitMqService>()
                    .Verify(x => x.SendData("test"), Times.Exactly(1));
            }
        }

        [Fact]
        public void GetMessage_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IRabbitMqService>()
                    .Setup(x => x.GetData())
                    .Returns("name");

                var cls = mock.Create<MessageComponent>();
                var expected = "name";

                var actual = cls.GetMessage();

                Assert.True(actual != null);
                Assert.Equal(expected, actual);
            }
        }
    }
}
