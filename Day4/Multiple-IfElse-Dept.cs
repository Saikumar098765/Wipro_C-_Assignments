using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class Multiple_IfElse_Dept
    {
        const int hrDept = 10;
        const int medicalDept = 20;
        const int sedicalDept = 30;
        const int travelDept = 50;
        public static void Main(string[] args)
        {
            Console.Write("Enter Your Dept Name : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num == hrDept)
            {
                Console.WriteLine("Your HR Dept");
            }
            else if (num == medicalDept)
            {
                Console.WriteLine("Your Medical Dept");
            }
            else if (num == sedicalDept)
            {
                Console.WriteLine("Your Sedical Dept");
            }
            else if (num == travelDept)
            {
                Console.WriteLine("Your Travel Dept");
            }
            else
            {
                Console.WriteLine("Your Not in any Dept");
            }


        }
    }
}
