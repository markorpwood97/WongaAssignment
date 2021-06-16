using System;
using System.Collections.Generic;
using System.Text;

namespace WongaLibrary.Components
{
    public interface IMessageComponent
    {
        public void SendMessage(string message, string queue);
        public string GetMessage(string queue);
    }
}
