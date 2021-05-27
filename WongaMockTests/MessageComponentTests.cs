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
        //[Fact]
        //public void SendMessage_ValidCall()
        //{
        //    using (var mock = AutoMock.GetLoose())
        //    {
        //        string message = "test";

        //        mock.Mock<IRabbitMqService>()
        //            .Setup(x => x.SendData(message));

        //        var cls = mock.Create<MessageComponent>();

        //        cls.SendMessage(message);

        //        Assert.True(0 == 0);

        //        mock.Mock<IRabbitMqService>()
        //            .Verify(x => x.SendData(message), Times.Exactly(1));
        //    }
        //}

        //[Fact]
        //public void GetMessage_ValidCall()
        //{
        //    using (var mock = AutoMock.GetLoose())
        //    {
        //        string message = "test";

        //        mock.Mock<IRabbitMqService>()
        //            .Setup(x => x.GetData())
        //            .Returns(message);

        //        var cls = mock.Create<MessageComponent>();
        //        var expected = message;

        //        var actual = cls.GetMessage();

        //        Assert.True(actual != null);
        //        Assert.Equal(expected, actual);
        //    }
        //}
    }
}
