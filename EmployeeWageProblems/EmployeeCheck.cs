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

        public string Company;
        public int EMP_PER_RATE_HOUR;
        public int NUM_OF_WORKING_DAYS;
        public int MAX_HRS_IN_MONTH;
        public int TOTAL_EMP_WAGE;
        public EmployeeCheck(string company, int emp_per_rate_hour, int num_of_working_days, int max_hrs_in_month)
        //Parameter constructor
        {

            this.Company = company;
            this.EMP_PER_RATE_HOUR = emp_per_rate_hour;
            this.NUM_OF_WORKING_DAYS = num_of_working_days;
            this.MAX_HRS_IN_MONTH = max_hrs_in_month;

        }
        public void CompanyWage()
        {
            int empHour = 0;
            int totalEmpHour = 0;
            int totalWorkingDays = 0;

            while (totalEmpHour <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
                Console.WriteLine("Day#: " + totalWorkingDays + "Emp Hour :" + empHour);
            }



            int totalEmpWage = totalEmpHour * EMP_PER_RATE_HOUR;


            Console.WriteLine("total Employee Wage: " + totalEmpWage);
        }
    }


}



