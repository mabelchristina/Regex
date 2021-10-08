using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class RegexDemonstration
    {
        const string FIRST_NAME = "^[A-Z]{1}[a-z]{3,}$";
       public void FirstNameChecker(string firstname)
        {
            if(Regex.IsMatch(firstname,FIRST_NAME))
            { 
                Console.WriteLine("FirstName is validated");
                return;
            }
            Console.WriteLine("FirstName is not validated");
        }
    }
}
