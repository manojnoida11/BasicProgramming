using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class EventExample
    {
        public delegate void GetMessage(string sMessage);
        public event GetMessage GetMessageEvent;

        private string _message;
        private void OnGetMessage()
        {
            if (GetMessageEvent != null)
            {
                GetMessageEvent(_message);
            }
        }

        public void TestEvent(string sMessage)
        {
            _message = sMessage;
            OnGetMessage();
        }



    }
}
