using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class WageComputation
    {
        const int IS_PRESENT = 0, WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8;
        int empHrs, EmpWage;
        public void EmployeeAttendence()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");

        }
        public void CalculateEmpWage()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == 0)
            {
                empHrs = 8;
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
