using System;
using System.Collections.Generic;
using System.Text;
using WongaLibrary.Components;

namespace ConsoleUIB
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
            string returnedMessage = _messageComponent.GetMessage("ConsoleB");
            string usersName = GreetingComponent.RemoveInitalGreeting(returnedMessage);
            if (!GreetingComponent.ValidateName(usersName))
            {
                Console.WriteLine("Please enter a valid name");
                return;
            }
            Console.WriteLine(GreetingComponent.AddIconicLine(usersName));
            Console.ReadLine();
        }
    }
}
