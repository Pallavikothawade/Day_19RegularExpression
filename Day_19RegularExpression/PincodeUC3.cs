using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_19RegularExpression
{
    class PincodeUC3
    {
        public void CheckAlphabetsUC3()
        {
            string pattern = "^[0-9][a-zA-Z]{6}$";
            string[] arr = { "1ABCDEF", "745622", "400088B", "1wasdfa", "A40088" };

            foreach (string input in arr)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is Valid", input);
                }
                else
                {
                    Console.WriteLine("{0} is InValid", input);
                }
            }
        }
    }
}
