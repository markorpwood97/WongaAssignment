using System;
using System.Collections.Generic;
using System.Text;

namespace WongaLibrary.Components
{
    public static class GreetingComponent
    {
        public static string AddInitialGreeting(string name)
        {
            return $"Hello my name is, { name }";
        }

        public static string RemoveInitalGreeting(string initialGreeting)
        {
            return initialGreeting.Replace("Hello my name is, ", "");
        }

        public static string AddIconicLine(string name)
        {
            return $"Hello { name }, I am your father";
        }

        public static bool ValidateName(string name)
        {
            char[] invalidCharacters = "`~!@#$%^&*()_+=0123456789<>,.?/\\|{}[]'\"".ToCharArray();

            return !string.IsNullOrWhiteSpace(name) || name.IndexOfAny(invalidCharacters) >= 0;
        }
    }
}
