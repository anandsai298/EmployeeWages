﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1,Full_Day_Hr =8,Part_Time_Hr =4,IS_FULL_TIME =0,IS_PART_TIME =1;//EmployeePresent(when constant is we have to use uppercase letters like IS_PRESENT)
        public void Attendence()
        {
            Random rand = new Random();//inbuilt class using which we can choose random number
            int check = rand.Next(0, 2);//we get o and 1 inner limit (outer is eleminated 2)
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
         //commit the code to uc1 branch and merge with main  
        }
        //uc2-dailyempwage
        public static int EmpWage(string Company,int Wage_Hr, int WORKING_DAYS_MONTH, int  TOTAL_WORKING_HRS)
        {
            int EmpHrs = 0;
            Random random = new Random();
            //calculating wages per month
            //calculate wages till total working hrs reached the month(100 hrs and 20 days)
            for (int i = 0; i < WORKING_DAYS_MONTH && EmpHrs < TOTAL_WORKING_HRS ; i++)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULL_TIME:
                        EmpHrs += Full_Day_Hr;
                        break;
                    case IS_PART_TIME:
                        EmpHrs += Part_Time_Hr;
                        break;
                    default:
                        EmpHrs += 0;
                        break;
                }
            }
            int Wage = Wage_Hr * EmpHrs;
            Console.WriteLine(Wage);
            return Wage;
        }
    }
}
