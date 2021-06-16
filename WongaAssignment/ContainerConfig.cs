using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using WongaLibrary.Components;
using WongaLibrary.Utilities;

namespace ConsoleUIA
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<RabbitMqService>().As<IRabbitMqService>();
            builder.RegisterType<MessageComponent>().As<IMessageComponent>();

            return builder.Build();
        }
    }
}
