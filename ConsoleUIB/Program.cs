using System;
using WongaLibrary.Components;
using WongaLibrary.Utilities;

namespace ConsoleUIB
{
    class Program
    {
        static void Main()
        {
            MessageComponent messageComponent = new MessageComponent(new RabbitMqService());
            string returnedMessage = messageComponent.GetMessage();

            string usersName = GreetingComponent.RemoveInitalGreeting(returnedMessage);
            Console.WriteLine(GreetingComponent.AddIconicLine(usersName));
            Console.ReadLine();
        }
    }
}
