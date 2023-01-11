using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_19RegularExpression
{
    class PincodeUc4
    {
        public void CheckAlphabetsUC4()
        {
            string pattern = "^[0-9][a-zA-Z]{6}$";
            string[] arr = { "400 088", "745622", "40008B", "1wasdfa", "A40088" };//UC4 400 088 invalid case

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
