using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Internal
{
    public class InternalEmployee
    {
        internal string GetMessage(string message)
        {
            return "Hello " + message;
        }

        protected internal string GetProtectedMessage(string message)
        {
            return "Hello Protected " + message;
        }
    }
}
