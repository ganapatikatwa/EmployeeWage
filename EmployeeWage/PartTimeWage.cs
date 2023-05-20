using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class PartTimeWage
    {
        public void PartTime()
        {
            //UC3-- Clculating Wages for Part Time
            int WorkingHrs = 0;
            int PartTime = 1;
            int FullTime = 2;
            int WagePerHr = 20;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if (empcheck == PartTime)
            {
                WorkingHrs = 8;
                Console.WriteLine("Employee is Working Part Time");
                Console.WriteLine("Employee working Part Time and Working Hrs--" + WorkingHrs);
                int PartTimeWage = WorkingHrs * WagePerHr;
                Console.WriteLine("The Wages for Part Time Working Employee--" + PartTimeWage);
            }
            else if (empcheck == FullTime)
            {
                WorkingHrs = 16;
                Console.WriteLine("Employee is Working Full Time");
                Console.WriteLine("Employee working Full Time and Working Hrs--" + WorkingHrs);
                int FullTimeWage = WorkingHrs * WagePerHr;
                Console.WriteLine("The Wages for Full Time Working Employee--" + FullTimeWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
