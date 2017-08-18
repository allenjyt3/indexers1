using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers170817
{
    class Program
    {
        static void Main(string[] args)
        {
            employee empobj = new employee(1,"Allen",3000000.00,"Database administrator");

            Console.WriteLine(empobj[0]);
            Console.WriteLine(empobj[1]);
            Console.WriteLine(empobj[2]);
            Console.WriteLine(empobj[3]);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

            empobj[0] = 2;
            empobj["EmpName"] = "Ajay";
            empobj[2] = 60000.00;
            empobj["Designation"] = "Software Developer";

            Console.WriteLine(empobj["Empid"]);
            Console.WriteLine(empobj["EmpName"]);
            Console.WriteLine(empobj["salary"]);
            Console.WriteLine(empobj["Designation"]);
            Console.ReadKey();
        }
    }

   public class employee

    {
         int Empid;
        string EmpName;
         double salary;
        string Designation;

       public employee(int Empid,string EmpName,double salary,string Designation)
        {
            this.Empid = Empid;
            this.EmpName = EmpName;
            this.salary = salary;
            this.Designation = Designation;
            
        }

      public object this[int index]

        {
            get
            {
                if (index == 0)
                    return Empid;
                else if (index == 1)
                    return EmpName;
                else if (index == 2)
                    return salary;
                else if (index == 3)
                    return Designation;
                return null;
            }
            set
            {
                if (index == 0)
                    Empid = (int)value;
                else if (index == 1)
                    EmpName = (string)value;
                else if (index == 2)
                    salary = (double)value;
                else if (index == 3)
                    Designation = (string)value;

            }
        }

         public object this[string index]

        {
            get
            {
                if (index == "Empid")
                    return Empid;
                else if (index == "EmpName")
                    return EmpName;
                else if (index == "salary")
                    return salary;
                else if (index == "Designation")
                    return Designation;
                return null;
            }
            set
            {
                if (index == "Empid")
                    Empid = (int)value;
                else if (index == "EmpName")
                    EmpName = (string)value;
                else if (index == "salary")
                    salary = (double)value;
                else if (index == "Designation")
                    Designation = (string)value;

            }


        }

           

    }


}
