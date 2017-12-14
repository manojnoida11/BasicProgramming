using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class Email
    {
        public string EmailUniqueHeader;
        public string From;
        public string To;
        public Email Parent;
    }

    public class Result
    {
        public string ParentMailId;
        public int TotalChildrenCount;
    }
    public class TestLinq
    {
        public void DoTestLinq()
        {
            List<Email> lstMailers = new List<Email>();
            List<Result> lstResults = new List<Result>();

            Email obj = new Email();
            obj.EmailUniqueHeader = "1";
            obj.From = "Manoj";
            obj.To = "Ravi";
            obj.Parent = null;

            Email objCh1 = new Email();
            objCh1.EmailUniqueHeader = "2";
            objCh1.From = "Ravi";
            objCh1.To = "Manoj";
            objCh1.Parent = obj;

            Email objCh2 = new Email();
            objCh2.EmailUniqueHeader = "3";
            objCh2.From = "Manoj";
            objCh2.To = "Ravi";
            objCh2.Parent = obj;

            lstMailers.Add(objCh2);

            var v = from r in lstMailers where r.From == "Manoj" select r;
            int icount = v.Count();
            foreach (var p in v)
            {
                Console.WriteLine(p.EmailUniqueHeader);
            }


        }
    }
}
