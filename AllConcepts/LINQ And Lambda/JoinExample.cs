using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllConcepts
{
    public class EmployeeStandard
    {
        public int Id;
        public string Standard;
    }
    public class JoinExample
    {
       

        public Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);

                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }

        private string ConvertDWordToString(object oVal)
        {
            int iVal = Convert.ToInt32(oVal);
            string strTemp = Convert.ToString(iVal, 2).PadLeft(32, '0');

            string strFirstEight = strTemp.Substring(0, 8);
            string strSecondEight = strTemp.Substring(8, 8);
            string strThirdEight = strTemp.Substring(16, 8);
            string strFourthEight = strTemp.Substring(24, 8);

            var data = GetBytesFromBinaryString(strFirstEight);
            strFirstEight = Encoding.ASCII.GetString(data);

            data = GetBytesFromBinaryString(strSecondEight);
            strSecondEight = Encoding.ASCII.GetString(data);

            data = GetBytesFromBinaryString(strThirdEight);
            strThirdEight = Encoding.ASCII.GetString(data);

            data = GetBytesFromBinaryString(strFourthEight);
            strFourthEight = Encoding.ASCII.GetString(data);

            return strFirstEight + strSecondEight + strThirdEight + strFourthEight;
            // return strFourthEight + strThirdEight + strSecondEight + strFirstEight;
        }

        public void TestJoin()
        {
            string str = this.ConvertDWordToString("842608690");
            List<Employee> EmployeeList = Program.FillList();
            List<EmployeeStandard> EmployeeStandardList = new List<EmployeeStandard>();

            EmployeeStandard obj = new EmployeeStandard();
            obj.Id = 1;
            obj.Standard = "std1";
            EmployeeStandardList.Add(obj);

            obj = new EmployeeStandard();
            obj.Id = 2;
            obj.Standard = "std2";
            EmployeeStandardList.Add(obj);

            obj = new EmployeeStandard();
            obj.Id = 3;
            obj.Standard = "std3";
            EmployeeStandardList.Add(obj);

            Console.WriteLine("*****************Using Linq****************************");
            var v = from e in EmployeeList
                    join st in EmployeeStandardList
                    on e.Id equals st.Id
                    select new
                        {
                            EmpoyeeName = e.Name,
                            Standard = st.Standard
                        };

            foreach (var k in v)
            {
                Console.WriteLine("Name {0}, Std {1}", k.EmpoyeeName, k.Standard);
            }
           
            Console.WriteLine("***************************Using Lambda*********************");

            var vLambda = EmployeeList.Join(EmployeeStandardList,
                                             e => e.Id,
                                             st => st.Id,
                                             (e, st) => new
                                             {
                                                 EmployeeName = e.Name,
                                                 Standard = st.Standard
                                             });

            foreach (var k in vLambda)
            {
                Console.WriteLine("Name {0}, Std {1}", k.EmployeeName, k.Standard);
            }
           

        }
    }
}
