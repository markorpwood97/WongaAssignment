using WongaLibrary;
using System;
using WongaLibrary.Components;
using WongaLibrary.Utilities;

namespace WongaAssignment
{
    class Program
    {
        static void Main()
        {
            MessageComponent messageComponent = new MessageComponent(new RabbitMqService());
            Console.WriteLine("Please enter your name");

            string greeting = GreetingComponent.AddInitialGreeting(Console.ReadLine());
            Console.WriteLine(greeting);

            messageComponent.SendMessage(greeting);
        }
    }
}
