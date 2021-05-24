namespace WongaLibrary.Components
{
    public interface IGreetingComponent
    {
        string AddIconicLine(string name);
        string AddInitialGreeting(string name);
        string RemoveInitalGreeting(string initialGreeting);
        bool ValidateName(string name);
    }
}