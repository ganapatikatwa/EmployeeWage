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

            int Present = 1;
            int WorkingHrs = 8;
            int WagePerHr = 20;
            Random random= new Random();
            int empcheck=random.Next(0,2);
            if (empcheck == Present)
            {
                Console.WriteLine("Employee is Working Hrs in Day--"+WorkingHrs);
                Console.WriteLine("Employee Wage per Hr--"+WagePerHr);
                int WagePerDay = WorkingHrs * WagePerHr;
                Console.WriteLine("The Wages of Employee Per Day--"+WagePerDay);
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }

        }
    }
}
