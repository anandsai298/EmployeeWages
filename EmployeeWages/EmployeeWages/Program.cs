// See https://aka.ms/new-console-template for more information
using System;
namespace EmployeeWages
{
    class program
    {
        static void Main(String[] args)
        {
            EmployeeWage wage = new EmployeeWage();
            wage.Attendence();
            wage.Daily_Emp_Wage();
        }
    }
}
