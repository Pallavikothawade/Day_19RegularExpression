using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_19RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome The Regular Expression");
            Console.WriteLine("Plz enter Your choice");
            Console.WriteLine("1.PincodeUC1\n2:PincodeUC2\n3:PincodeUC3\n4:PincodeUc4\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    PincodeUC1 pincodeUC1 = new PincodeUC1();
                    pincodeUC1.Check_sixdigit();
                    break;
                case 2:
                    PincodeUC2 pincode = new PincodeUC2();
                    pincode.CheckAlphabets();
                    break;
                case 3:
                    PincodeUC3 pincodeUC3 = new PincodeUC3();
                    pincodeUC3.CheckAlphabetsUC3();
                    break;
                case 4:
                    PincodeUc4 pincodeUc4 = new PincodeUc4();
                    pincodeUc4.CheckAlphabetsUC4();
                    break;

            }
            Console.ReadLine();
        }
    }
}
