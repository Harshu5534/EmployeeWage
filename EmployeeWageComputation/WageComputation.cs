using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class WageComputation
    {
        const int WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8;
        int IS_FULL_TIME = 1, IS_PART_TIME = 2;
        int empHrs, EmpWage;
        public void EmployeeAttendence()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_FULL_TIME)
                Console.WriteLine("Employee is Present");
            else if (check == IS_PART_TIME)
                Console.WriteLine("Employee is PartTime");
            else
                Console.WriteLine("Employee is Absent");

        }
        public void CalculateEmpWage()
        {
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if (check == IS_PART_TIME) 
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            EmpWage = empHrs * WAGE_PER_HOUR;
            Console.WriteLine("Emp Wage for a day:" +EmpWage);
        }
      
    }
}
