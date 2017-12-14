using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Internal;
namespace AllConcepts.OOPS
{
    class InternalDemo : InternalEmployee
    {
        public void Test()
        {
            //can't access internal employee as provided by internal library because 
            //it was declared internal.
            InternalEmployee obj = new InternalEmployee();
          
            //Can't access GetMessage method because it was declared internal.
            //But can access the protected internal message in derived class.
            string str = GetProtectedMessage("Manoj");

           
        }
    }
}
