using System;
using System.Collections.Generic;
using System.Text;
using WongaLibrary.Components;
using WongaLibrary.Utilities;

namespace WongaLibrary
{
    public static class Factory
    {
        public static IRabbitMqService CreateRabbitMqService()
        {
            return new RabbitMqService();
        }

        public static IMessageComponent CreateMessageComponent()
        {
            return new MessageComponent(CreateRabbitMqService());
        }

        public static IGreetingComponent CreateGreetingComponent()
        {
            return new GreetingComponent();
        }
    }
}
