using System;

namespace EmployeeWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            //UC1- Employee Present or Absent

            //int Present = 1;
            //Random random= new Random();
            //int empcheck=random.Next(0,2);
            //Console.WriteLine("Random Number is--"+empcheck);
            //if(empcheck==Present)
            //{
            //    Console.WriteLine("Employee is Presnt");
            //}
            //else
            //{
            //    Console.WriteLine("Employee is Absent");
            //}

            //UC2--Calculate Daily Employee Wage

            //int Present = 1;
            //int WorkingHrs = 8;
            //int WagePerHr = 20;
            //Random random= new Random();
            //int empcheck=random.Next(0,2);
            //if (empcheck == Present)
            //{
            //    Console.WriteLine("Employee is Working Hrs in Day--"+WorkingHrs);
            //    Console.WriteLine("Employee Wage per Hr--"+WagePerHr);
            //    int WagePerDay = WorkingHrs * WagePerHr;
            //    Console.WriteLine("The Wages of Employee Per Day--"+WagePerDay);
            //}
            //else
            //{
            //    Console.WriteLine("Employee Is Absent");
            //}

            //UC3-- Clculating Wages for Part Time
            //int WorkingHrs = 0;
            //int PartTime = 1;
            //int FullTime = 2;
            //int WagePerHr = 20;
            //Random random= new Random();
            //int empcheck= random.Next(0,3);
            //if (empcheck == PartTime)
            //{
            //    WorkingHrs= 8;
            //    Console.WriteLine("Employee is Working Part Time");
            //    Console.WriteLine("Employee working Part Time and Working Hrs--"+WorkingHrs);
            //    int PartTimeWage = WorkingHrs * WagePerHr;
            //    Console.WriteLine("The Wages for Part Time Working Employee--"+PartTimeWage);
            //}
            //else if(empcheck==FullTime)
            //{
            //    WorkingHrs= 16;
            //    Console.WriteLine("Employee is Working Full Time");
            //    Console.WriteLine("Employee working Full Time and Working Hrs--" + WorkingHrs);
            //    int FullTimeWage = WorkingHrs * WagePerHr;
            //    Console.WriteLine("The Wages for Full Time Working Employee--" + FullTimeWage);
            //}
            //else
            //{
            //    Console.WriteLine("Employee is Absent");
            //}

            //UC4--Using Switch Case Statement
            int WorkingHrs = 0;
            int PartTime = 1;
            int FullTime = 2;
            int WagePerHr = 20;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            Console.WriteLine(empcheck);
            switch(empcheck)
            {
                case 1: 
                    WorkingHrs=8;
                    Console.WriteLine("Employee Working Hrs is--" + WorkingHrs);
                    int PartTimeWage = WorkingHrs * WagePerHr;
                    Console.WriteLine("Part Time Wage--"+PartTimeWage);
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
