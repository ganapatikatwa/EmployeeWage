using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class WagesMonth
    {
        public void EmpWage()
        {
            int PartTime = 1;
            int FullTime = 2;
            int WagePerHr = 20;
            int WorkDays = 20;
            int empwage = 0;
            int emphrs = 0;
            int totalempwage = 0;

            for(int Day=0;Day<=WorkDays;Day++)
            {
                Random random= new Random();
                int empcheck=random.Next(1,3);
                switch(empcheck)
                {
                    case 1:
                        emphrs = 8;
                        break;
                    case 2:
                        emphrs = 16;
                        break;
                    default:
                        emphrs= 0;
                        break;
                }
                empwage = emphrs * WagePerHr;
                totalempwage+= empwage;
                Console.WriteLine("Employee Wage--"+empwage);
               
            }
            Console.WriteLine("Total Employee Wage--"+totalempwage);
        }
    }
}
