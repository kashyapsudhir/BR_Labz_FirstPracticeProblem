using EmployeeWageProblems;
using System;

namespace EmployeeWageComputation
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation day 8 using class and method ");


            EmployeeCheck employeeCheck = new EmployeeCheck();
            Console.WriteLine("enter employee per rate hour of your company");
            int emp_per_rate_hour_of_compny = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number of working days of your company");
            int num_of_working_days_of_company = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter maximum hours in month of as per as your company rule ");
            int max_hrs_in_month_of_company = Convert.ToInt32(Console.ReadLine());

            employeeCheck.EmployeeAttendance(emp_per_rate_hour_of_compny, num_of_working_days_of_company, max_hrs_in_month_of_company);
           


        }
    }
}