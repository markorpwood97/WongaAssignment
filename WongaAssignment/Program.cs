using WongaLibrary;
using System;

namespace WongaAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name");

            string name = GreetingComponent.AddInitialGreeting(Console.ReadLine());
            Console.WriteLine(name);

            MessageService.Send("starwars", name);
        }
    }
}
