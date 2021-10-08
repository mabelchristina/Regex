using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class RegexDemonstration
    {
        const string NAME = "^[A-Z]{1}[a-z]{3,}$";
        const string EMAIL = "^[A-Z0-9a-z]{1,}([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public void FirstNameChecker(string firstname)
        {
            if (Regex.IsMatch(firstname, NAME))
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
        public void EmailValidation(string email)
        {
            if (Regex.IsMatch(email,EMAIL))
            {
                Console.WriteLine("Email is validated");
                return;
            }
            Console.WriteLine("Email is not validated");
        }
    }
}
