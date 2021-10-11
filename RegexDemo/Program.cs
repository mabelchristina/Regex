using System;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexDemonstration regexDemonstration = new RegexDemonstration();
            bool isExit = false;
            while(!isExit)
            {
                Console.WriteLine("choose an option to validate \n 1.First Name Validation\n2.Last Name Validation\n" +
                    "3.Email Validation\n4.Mobile number validation\n5.Password validation\n6.Password with atleast one UpperCase Letter");
                int option =Convert.ToInt32( Console.ReadLine());
                switch(option)
                {
                    case 1:
                        regexDemonstration.FirstNameChecker("Mabel");
                        break;
                    case 2:
                        regexDemonstration.LastNameChecker("Christina");
                        break;
                    case 3:
                        regexDemonstration.EmailValidation("abc@%*.com");
                        break;
                    case 4:
                        regexDemonstration.PhoneNumberValidation("91 8553635345");
                        break;
                    case 5:
                        regexDemonstration.PasswordValidation("wdkmewfk@!#@!");
                        break;
                    case 6:
                        regexDemonstration.PasswordValidation("Aokrw");
                        break;

                }

            }
        }
    }
}
