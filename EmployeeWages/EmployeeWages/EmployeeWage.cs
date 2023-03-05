using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1;//EmployeePresent(when constant is we have to use uppercase letters like IS_PRESENT)
        public void Attendence()
        {
            Random rand = new Random();//inbuilt class using which we can choose random number
            int check = rand.Next(0, 2);//we get o and 1 inner limit (outer is eleminated 2)
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");//commit the code to uc1 branch and merge with main

        }
    }
}
