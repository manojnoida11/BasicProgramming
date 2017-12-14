using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AllConcepts
{
    public class DisposeAndFinalize : IDisposable
    {
        AnonymousMethods objMethods = new AnonymousMethods();
        FileStream fs = new FileStream("c:\\abc.txt", FileMode.Create);

        public DisposeAndFinalize()
        {
            Console.WriteLine("Inside dispose and finalize constructor");
        }

        ~DisposeAndFinalize()
        {
            Console.WriteLine("Inside dispose and finalize destructor");
            Dispose(false);
        }
        public void Dispose()
        {
            Console.WriteLine("Disposing...");
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        public void Dispose(bool disposing)
        {
            
            if (disposed == false)
            {
                objMethods = null;

                fs.Close();
                fs.Dispose();
                disposed = true;
            }

 
        }
    }
}
