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
            IMessageComponent messageComponent = Factory.CreateMessageComponent();
            Console.WriteLine("Please enter your name");

            IGreetingComponent greetingComponent = Factory.CreateGreetingComponent();
            string greeting = greetingComponent.AddInitialGreeting(Console.ReadLine());
            Console.WriteLine(greeting);

            messageComponent.SendMessage(greeting);
        }
    }
}
