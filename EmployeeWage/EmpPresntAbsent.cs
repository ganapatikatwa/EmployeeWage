using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpPresntAbsent
    {
        public  void EmpPorA()
        {
            //UC1- Employee Present or Absent

            int Present = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            Console.WriteLine("Random Number is--" + empcheck);
            if (empcheck == Present)
            {
                Console.WriteLine("Employee is Presnt");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

       
    }
}
