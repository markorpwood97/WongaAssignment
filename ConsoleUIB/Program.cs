using System;
using WongaLibrary;
using WongaLibrary.Components;

namespace ConsoleUIB
{
    class Program
    {
        static void Main()
        {
            IMessageComponent messageComponent = Factory.CreateMessageComponent();
            IGreetingComponent greetingComponent = Factory.CreateGreetingComponent();

            string returnedMessage = messageComponent.GetMessage();
            string usersName = greetingComponent.RemoveInitalGreeting(returnedMessage);
            if (!greetingComponent.ValidateName(usersName))
            {
                Console.WriteLine("Please enter a valid name");
                return;
            }
            Console.WriteLine(greetingComponent.AddIconicLine(usersName));
            Console.ReadLine();
        }
    }
}
