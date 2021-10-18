using System;
using System.IO;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate validate = new Validate();
            const string NAME = "^[A-Z]{1}[a-z]{3,}$";
            const string EMAIL = "^[A-Z0-9a-z]{1,}([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            const string MOBILE_NUMBER = "^[0-9]{2}[ ]{1}[6-9]{1}[0-9]{9}$";
            const string PASSWORD = "[A-Z]+.{8,}?";//"^(?=.*[A-Z]).{8,}$";
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine(validate.checkIfValid(NAME, firstName));
            Console.WriteLine("Enter Last Name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine(validate.checkIfValid(NAME, lastName));
            Console.WriteLine("Enter Email ID : ");
            string emailID = Console.ReadLine();
            Console.WriteLine(validate.checkIfValid(EMAIL, emailID));
            Console.WriteLine("Enter Mobile Number : ");
            string mobileNum = Console.ReadLine();
            Console.WriteLine(validate.checkIfValid(MOBILE_NUMBER, mobileNum));
            Console.WriteLine("enter password : ");
            string password = Console.ReadLine();
            Console.WriteLine(validate.checkIfValid(PASSWORD, password));
        }
    }
}
