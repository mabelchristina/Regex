using NUnit.Framework;
using RegexDemo;

namespace UserRegistrationTest
{
    public class Tests
    {
        [Test]
        public void GivenUserInput_shouldValidate_UserRegistration()
        {
            bool expected = true;
            const string NAME = "^[A-Z]{1}[a-z]{3,}$";
            const string EMAIL = "^[A-Z0-9a-z]{1,}([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            const string MOBILE_NUMBER = "^[0-9]{2}[ ]{1}[6-9]{1}[0-9]{9}$";
            const string PASSWORD = "[A-Z]+.{8,}?";//"^(?=.*[A-Z]).{8,}$";
            string firstName = "Mabel";
            string lastName = "Christina";
            string emailID = "maybelchristina@gmail.com";
            string mobileNum = "91 8553635345";
            string password = "Maybelchristina@123";
            Validate validate = new Validate();
            Assert.AreEqual(expected, validate.checkIfValid(NAME, firstName));
            Assert.AreEqual(expected, validate.checkIfValid(NAME, lastName));
            Assert.AreEqual(expected, validate.checkIfValid(EMAIL, emailID));
            Assert.AreEqual(expected, validate.checkIfValid(MOBILE_NUMBER, mobileNum));
            Assert.AreEqual(expected, validate.checkIfValid(PASSWORD, password));
        }
    }
}