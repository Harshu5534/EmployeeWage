using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class WageComputation
    {
        const int WAGE_PER_HOUR = 20, IS_FULL_DAY_HOUR = 8, IS_PART_TIME_HOUR = 4;
        const int IS_FULL_TIME_PRESENT = 1, IS_PART_TIME_PRESENT = 2, WORKING_DAYS_PER_MONTH = 20;
        int empHrs, totalEmpWage;
        public void EmployeeAttendence()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_FULL_TIME_PRESENT)
                Console.WriteLine("Employee is Present");
            else if (check == IS_PART_TIME_PRESENT)
                Console.WriteLine("Employee is PartTime");
            else
                Console.WriteLine("Employee is Absent");

        }
        public int CalculateEmpWage()
        {
            for (int i = 0; i < WORKING_DAYS_PER_MONTH; i++)
            {
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULL_TIME_PRESENT:
                        empHrs = IS_FULL_DAY_HOUR;
                        break;

                    case IS_PART_TIME_PRESENT:
                        empHrs = IS_PART_TIME_HOUR;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
            }
            totalEmpWage = empHrs * WAGE_PER_HOUR;
            Console.WriteLine("Emp Wage for a day:" + totalEmpWage);
            return totalEmpWage;
        }
        public void TotalEmpWage()
        {
            int wage = 0;
            for (int i = 0; i < WORKING_DAYS_PER_MONTH; i++)
            {
                wage += this.CalculateEmpWage();
            }
        }
    }
}
