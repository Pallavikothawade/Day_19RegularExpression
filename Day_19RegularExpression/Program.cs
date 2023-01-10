using System;
using System.Collections.Generic;
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
            Console.WriteLine("1.Pincode\n");
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

            }
            Console.ReadLine();
        }
    }
}
