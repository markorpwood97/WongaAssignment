using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using WongaLibrary.Components;
using WongaLibrary.Utilities;

namespace WongaLibrary
{
    public static class GlobalContainerConfig
    {
        public static ContainerBuilder Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<RabbitMqService>().As<IRabbitMqService>();
            builder.RegisterType<MessageComponent>().As<IMessageComponent>();

            return builder;
        }
    }
}
