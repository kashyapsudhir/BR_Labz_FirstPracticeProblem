using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    public class EmployeeCheck
    {
        public static void EmployeeAttendance()
        {
            int EMP_PER_RATE_HOUR = 20;
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int empHour = 0;
            int empWage = 0;
            Random rdm = new Random();
            int empCheck = rdm.Next(3);
            Console.WriteLine("Random value: " + empCheck);
            if (empCheck == IS_FULL_TIME)
            {
                empHour = 8;
            }
            else if(empCheck == IS_PART_TIME)
            {
                empHour = 4;
            }
            else 
            {
                empHour = 0;
            }
            empWage = empHour * EMP_PER_RATE_HOUR;
            Console.WriteLine("Employee Wage: "+ empWage);

        }

    }
}
