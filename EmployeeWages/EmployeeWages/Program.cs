using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int Full_Time = 1;
            int Emp_rate_per_Hrs = 20;
            int empHrs, empWage;
            Random r = new Random();
            int check = r.Next(1, 3);
            if (check == Full_Time)
            {
                empHrs = 8;
            }
            else
                empHrs = 0;

            empWage = empHrs * Emp_rate_per_Hrs;
            Console.WriteLine("Employee Wages: " + empWage);
        }
    }
}
