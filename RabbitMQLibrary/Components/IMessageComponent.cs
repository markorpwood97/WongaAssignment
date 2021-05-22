using System;
using System.Collections.Generic;
using System.Text;

namespace WongaLibrary.Components
{
    interface IMessageComponent
    {
        public void SendMessage(string message);
        public string GetMessage();
    }
}
