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

            switch (check)
            {
                case 1:
                    empHrs = 8;
                    break;
                case 2:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            empWage = empHrs * Emp_rate_per_Hrs;
            Console.WriteLine("Employee Wages: " + empWage);
        }
    }
}
