using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_19RegularExpression
{
    class PincodeUC1
    {
        public void Check_sixdigit()
        {
            string pattern = "^[0-9]{6}$";
            string[] arr = {"203546","7456B2","236545","40023M","40235A"};
                foreach(string input in arr)
                {
                      if(Regex.IsMatch(input,pattern))
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
