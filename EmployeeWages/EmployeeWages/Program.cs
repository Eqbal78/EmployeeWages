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
            int No_Of_Working_Days = 20;
            int empHrs, empWage;
            int totalEmpWage = 0;

            for (int i = 0; i < No_Of_Working_Days; i++)
            {
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
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wages: " + empWage);
            }

            Console.WriteLine("Total Emp Wages: " + totalEmpWage);
        }
    }
}
