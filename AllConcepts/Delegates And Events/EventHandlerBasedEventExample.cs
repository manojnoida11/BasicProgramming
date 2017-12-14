using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class EventHandlerBasedEventExample
    {
        public event EventHandler<MyEventArgs> DataNotification;
        
        
        private string message;

        public void OnDataNotification()    
        {
            if (DataNotification != null)
            {
                this.DataNotification(this, new MyEventArgs(message));
            }
        }

        public void TestEventHandlerBasedExample(string s)
        {
            this.message = s;
            OnDataNotification();
        }
    }

    public class MyEventArgs : EventArgs
    {
        public string Message
        {
            get;
            set;
        }

        public MyEventArgs(string message)
        {
            this.Message = message;
        }

    }
}
