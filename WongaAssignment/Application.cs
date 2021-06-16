using System;
using System.Collections.Generic;
using System.Text;
using WongaLibrary.Components;

namespace ConsoleUIA
{
    public class Application : IApplication
    {
        IMessageComponent _messageComponent;

        public Application(IMessageComponent messageComponent)
        {
            _messageComponent = messageComponent;
        }

        public void Run()
        {
            Console.WriteLine("Please enter your name");

            string greeting = GreetingComponent.AddInitialGreeting(Console.ReadLine());
            Console.WriteLine(greeting);

            _messageComponent.SendMessage(greeting, "ConsoleB");
        }
    }
}
