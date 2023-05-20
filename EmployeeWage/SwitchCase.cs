using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class SwitchCase
    {
        public void Empwage()
        {
            ////UC4--Using Switch Case Statement
            int WorkingHrs = 0;
            int PartTime = 1;
            int FullTime = 2;
            int WagePerHr = 20;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            Console.WriteLine(empcheck);
            switch (empcheck)
            {
                case 1:
                    WorkingHrs = 8;
                    Console.WriteLine("Employee Working Hrs is--" + WorkingHrs);
                    int PartTimeWage = WorkingHrs * WagePerHr;
                    Console.WriteLine("Part Time Wage--" + PartTimeWage);
                    break;
                case 2:
                    WorkingHrs = 16;
                    Console.WriteLine("Employee Working Hrs is--" + WorkingHrs);
                    int FullTimeWage = WorkingHrs * WagePerHr;
                    Console.WriteLine("Part Time Wage--" + FullTimeWage);
                    break;
                default:
                    WorkingHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }
        }
    }
}
