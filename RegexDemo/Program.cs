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
                Console.WriteLine("choose an option to validate \n 1.First Name Validation\n2.Last Name Validation\n3.Email Validation\n" +
                    "4.Mobile number validation\n");
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
                        regexDemonstration.EmailValidation("mabelchristina@bridgelabz.com");
                        break;
                    case 4:
                        regexDemonstration.PhoneNumberValidation("91 8553635345");
                        break;


                }

            }
        }
    }
}
