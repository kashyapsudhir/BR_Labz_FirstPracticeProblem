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
            int IS_FULL_TIME = 1;
            Random rdm = new Random();
            int empCheck = rdm.Next(2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }

    }
}
