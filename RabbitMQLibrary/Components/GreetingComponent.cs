﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WongaLibrary.Components
{
    public class GreetingComponent : IGreetingComponent
    {
        public string AddInitialGreeting(string name)
        {
            return $"Hello my name is, { name }";
        }

        public string RemoveInitalGreeting(string initialGreeting)
        {
            return initialGreeting.Replace("Hello my name is, ", "");
        }

        public string AddIconicLine(string name)
        {
            return $"Hello { name }, I am your father";
        }

        public bool ValidateName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }
    }
}