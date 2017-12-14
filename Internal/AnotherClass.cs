using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Internal
{
   public  class AnotherClass : InternalEmployee 
    {
       private void Test()
       {
           string str = GetProtectedMessage("manoj");
       }
    }
}
