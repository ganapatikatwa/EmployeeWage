using System;

namespace EmployeeWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            //UC1- Employee Present or Absent
            int Present = 1;
            Random random= new Random();
            int empcheck=random.Next(0,2);
            Console.WriteLine("Random Number is--"+empcheck);
            if(empcheck==Present)
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
