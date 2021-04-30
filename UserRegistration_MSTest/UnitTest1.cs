using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Rejex_UserRegistration_Test;

namespace UserRegistration_MSTest
{
    [TestClass]
    public class Rejex_UserRegistration_Test
    {
        [TestMethod]
        public void TestValidateFirstName()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.ValidateFirstName("Shubham");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidateLastName()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.ValidateLastName("Bodake");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidateEmail()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.ValidateEmail("Shubham@gmail.com");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidateMobileNumber()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.ValidateMobileNumber("91 7757929383");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidatePassword()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.ValidatePassword("Shubhambodake");
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void TestValidatePasswordRule2()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.ValidatePasswordRule2("Shubham1234");
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void TestValidatePasswordRule3()
        {
            Pattern pattern = new Pattern();
            bool result = pattern.ValidatePasswordRule3("Shubham@1345");
            Assert.IsTrue(result);
        }

    }
}
