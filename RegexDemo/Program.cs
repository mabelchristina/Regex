using System;
using System.IO;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationDemo userRegistrationDemo = new UserRegistrationDemo();
            Console.WriteLine("Name To Enter");
            string Name = Console.ReadLine();
            Console.WriteLine("Last Name To Enter");
            string LastName = Console.ReadLine();
            Console.WriteLine("Email To Enter");
            string Email = Console.ReadLine();
            Console.WriteLine("Number to Enter using Country Code");
            string Number = Console.ReadLine();
            Console.WriteLine("Password To Enter ");
            Console.WriteLine("1 . Must Have Atleat 8 character" + "\n" + "2 . One Character Should be in upper case" + "\n" + "3 . One character Should Be in Lower Case " + "\n" + "4 . One Special Character " + "\n" + "5. Should Have One Numberic Value");
            string Password = Console.ReadLine();
            if (userRegistrationDemo.ToCheckName(Name) == true)
                Console.WriteLine("Valid Input");
            else
                Console.WriteLine("InValid Input");
            if (userRegistrationDemo.ToCheckLastName(LastName) == true)
                Console.WriteLine("Valid Input");
            else
                Console.WriteLine("InValid Input");
            if (userRegistrationDemo.ToCheckMail(Email) == true)
                Console.WriteLine("Valid Input");
            else
                Console.WriteLine("InValid Input");
            if (userRegistrationDemo.ToCheckNumber(Number) == true)
                Console.WriteLine("Vaild Input");
            else
                Console.WriteLine("Invalid Input");
            if (userRegistrationDemo.ToCheckPassword(Password) == true)
                Console.WriteLine("Vaild Input");
            else
                Console.WriteLine("Invalid Input");
        }
    }
}
