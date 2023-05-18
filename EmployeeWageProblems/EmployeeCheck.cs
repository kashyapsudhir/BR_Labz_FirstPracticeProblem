using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    public class EmployeeCheck
    {

        //Class variable declare here according to UC7

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_PER_RATE_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 5;
        public const int MAX_HRS_IN_MONTH = 10;
        public static void EmployeeAttendance() //method here acording to UC7
        {
            
            int empHour = 0;
            int totalEmpHour = 0;
            int totalWorkingDays = 0;
            while (totalEmpHour<=MAX_HRS_IN_MONTH) 
            {
                totalWorkingDays++;
                Random rdm = new Random();
                int empCheck = rdm.Next(3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHour += 4;
                        break;

                    case IS_FULL_TIME:
                        empHour = 8;
                        break;

                    default:
                        empHour = 0;
                        break;
                }

                totalEmpHour = totalEmpHour + empHour;
                Console.WriteLine("Day#: " + totalWorkingDays+ "Emp Hour :" + empHour);
               


            }
            int totalEmpWage = totalEmpHour * EMP_PER_RATE_HOUR;

           
            Console.WriteLine("total Employee Wage: " + totalEmpWage);



        }

    }
}
