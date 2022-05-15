using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Wage_Multiple_Company
{
    internal class Muliple_Company
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int MaxHourPerMonth)
        {
            //vaiables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= MaxHourPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs; // totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs " + empHrs);
            }
            int totalempwage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company : " + company + " is: " + totalempwage);
            return totalempwage;
        }
        public static void ComputeEmpWage()
        {
            ComputeEmpWage("Dmart", 20, 2, 10);
            ComputeEmpWage("Reliance", 10, 4, 20);

        }






    }
}
