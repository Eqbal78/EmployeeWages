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
            int Max_Working_Days = 20;
            int Max_Working_Hrs = 100;
            int empHrs = 0, empWage=0;
            int workingHrs = 0;
            int totalEmpWage = 0;
            int No_of_Working_Days = 0;


            while (No_of_Working_Days <= Max_Working_Days && workingHrs <= Max_Working_Hrs)
            {
                No_of_Working_Days++;
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
                workingHrs += empHrs;
                Console.WriteLine("Days: " + workingHrs + " Emp Hrs: " + empHrs);
                empWage = empHrs * Emp_rate_per_Hrs;
            }
            //empWage = empHrs * Emp_rate_per_Hrs;
            Console.WriteLine("Employee Wages: " + empWage);
        }
    }
}
