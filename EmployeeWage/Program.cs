using System;

namespace EmployeeWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            while (true)
            {
                Console.WriteLine("Select The Choice");
                Console.WriteLine("1)Employee Presnt or Absent \n 2) Daily Wage \n " +
                    "3)Clculating Wages for Part Time\n 4)Using Switch Case Statement" +
                    "\n 5)WagesMonth \n6) Max Days and Hours");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EmpPresntAbsent empresentabsent = new EmpPresntAbsent();
                        empresentabsent.EmpPorA();
                        break;
                    case 2:
                        DailyWage dailywage = new DailyWage();
                        dailywage.DayWage();
                        break;
                    case 3:
                        PartTimeWage parttimewage = new PartTimeWage();
                        parttimewage.PartTime();
                        break;
                    case 4:
                        SwitchCase switchcase = new SwitchCase();
                        switchcase.Empwage();
                        break;
                    case 5:
                        WagesMonth wagesmonth = new WagesMonth();
                        wagesmonth.EmpWage();
                        break;
                    case 6:
                        MaxDaysHours maxdayshours= new MaxDaysHours();
                        maxdayshours.MaxWage();
                        break;

                }

                
            }

        }
    }
}
