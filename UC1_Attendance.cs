using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3EmployeeWageProblem
{
    internal class UC1_Attendance
    {
        public static void Attendance()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();// new object creation
            int empCheck = random.Next(0, 2);//0 is inclusive,2 is exclusive: 0,1
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("employee is Present");
            }
            else
            {
                Console.WriteLine("employee is Absent");
            }
        }
    }
}
