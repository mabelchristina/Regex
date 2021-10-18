using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class UserRegistrationDemo
    {
        const string NAME = "^[A-Z]{1}[a-z]{3,}$";
        const string EMAIL = "^[A-Z0-9a-z]{1,}([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        const string MOBILE_NUMBER = "^[0-9]{2}[ ]{1}[6-9]{1}[0-9]{9}$";
        const string PASSWORD = "[A-Z]+.{8,}?";//"^(?=.*[A-Z]).{8,}$";
        public bool ToCheckName(string name) => (Regex.IsMatch(name, NAME));

        public bool ToCheckLastName(string lastName) => (Regex.IsMatch(lastName, NAME));

        public bool ToCheckMail(string mail) => (Regex.IsMatch(mail, EMAIL));

        public bool ToCheckNumber(string number) => (Regex.IsMatch(number, MOBILE_NUMBER));

        public bool ToCheckPassword(string password) => (Regex.IsMatch(password, PASSWORD));
    }
}
