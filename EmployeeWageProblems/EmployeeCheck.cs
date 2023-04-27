using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    public class EmployeeCheck
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_PER_RATE_HOUR = 20;
        public static void EmployeeAttendance()
        {
            
            int empHour = 0;
            int empWage = 0;
            Random rdm = new Random();
            int empCheck = rdm.Next(3);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHour = 4;
                    break;

                case IS_FULL_TIME:
                    empHour = 8;
                    break;

                default:
                    empHour = 0;
                    break;
            }
            
            empWage = empHour * EMP_PER_RATE_HOUR;
            Console.WriteLine("Employee Wage: "+ empWage);

        }

    }
}
