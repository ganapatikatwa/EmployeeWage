using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class DailyWage
    {
        public  void DayWage()
        {
            //UC2--Calculate Daily Employee Wage

            int Present = 1;
            int WorkingHrs = 8;
            int WagePerHr = 20;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == Present)
            {
                Console.WriteLine("Employee is Working Hrs in Day--" + WorkingHrs);
                Console.WriteLine("Employee Wage per Hr--" + WagePerHr);
                int WagePerDay = WorkingHrs * WagePerHr;
                Console.WriteLine("The Wages of Employee Per Day--" + WagePerDay);
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
        }

    }
}
