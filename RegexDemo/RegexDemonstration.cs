using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class RegexDemonstration
    {
        const string NAME = "^[A-Z]{1}[a-z]{3,}$";
       public void FirstNameChecker(string firstname)
        {
            if(Regex.IsMatch(firstname,NAME))
            { 
                Console.WriteLine("FirstName is validated");
                return;
            }
            Console.WriteLine("FirstName is not validated");
        }
        public void LastNameChecker(string lastname)
        {
            if (Regex.IsMatch(lastname, NAME))
            {
                Console.WriteLine("LastName is validated");
                return;
            }
            Console.WriteLine("LastName is not validated");
        }
    }
}
