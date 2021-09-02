using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int Full_Time = 1;
            int Part_Time = 2;
            int Emp_rate_per_Hrs = 20;
            int empHrs, empWage;
            Random r = new Random();
            int check = r.Next(1, 4);
            if (check == Full_Time)
            {
                empHrs = 8;
            }
            else if (check == Part_Time)
            {
                empHrs = 4;
            }
            else
                empHrs = 0;

            empWage = empHrs * Emp_rate_per_Hrs;
            Console.WriteLine("Employee Wages: " + empWage);
        }
    }
}
