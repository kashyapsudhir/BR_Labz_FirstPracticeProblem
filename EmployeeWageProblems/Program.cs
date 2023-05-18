using EmployeeWageProblems;
using System;

namespace EmployeeWageComputation
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation day 8 using class and method ");


            EmployeeCheck TCS_Company = new EmployeeCheck("TCS",20,5,100);
            TCS_Company.CompanyWage();

            EmployeeCheck Wipro_Comapany = new EmployeeCheck("Wipro_Comapany", 15, 5, 120);
            Wipro_Comapany.CompanyWage();

        }
    }
}