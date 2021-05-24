using System;
using WongaLibrary;
using WongaLibrary.Components;
using WongaLibrary.Utilities;

namespace ConsoleUIB
{
    class Program
    {
        static void Main()
        {
            IMessageComponent messageComponent = Factory.CreateMessageComponent();
            string returnedMessage = messageComponent.GetMessage();
            IGreetingComponent greetingComponent = Factory.CreateGreetingComponent();

            string usersName = greetingComponent.RemoveInitalGreeting(returnedMessage);
            Console.WriteLine(greetingComponent.AddIconicLine(usersName));
            Console.ReadLine();
        }
    }
}
