using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class MaxDaysHours
    {
        public void MaxWage()
        {
            int PartTime = 1;
            int FullTime = 2;
            int WagePerHr = 20;
            int WorkDays = 20;
            int WorkHours = 100;
            int empwage = 0;
            int emphrs = 0;
            int totalempwage = 0;
            int totalemphrs = 0;
            int totalworkdays = 0;

            while(totalemphrs<=WorkHours && totalworkdays<=WorkDays)
            {
                totalworkdays++;
                Random random= new Random();
                int empcheck= random.Next(0,3);

                switch(empcheck)
                {
                    case 1:
                        emphrs = 8;
                        break;
                    case 2:
                        emphrs = 16;
                        break;
                    default:
                        emphrs=0;   
                        break;
                }
                totalemphrs += emphrs;
                Console.WriteLine("Days--"+totalworkdays+"Employee Hours--"+emphrs);
            }
                totalempwage = totalemphrs * WagePerHr;
            Console.WriteLine("Total Employee Wage--"+totalempwage);
            Console.WriteLine("Total Employee Hrs--"+totalemphrs);
        }
    }
}
