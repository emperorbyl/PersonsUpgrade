using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonsUpgrade;

namespace PersonsUpgradeTest
{
    [TestClass]
    public class SocialSecurityNumberMatcherTester
    {
        [TestMethod]
        public void SSNConstructorTest()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            SocialSecurityMatch ssn = new SocialSecurityMatch(person1, person2);
            Assert.IsNotNull(person1);
            Assert.IsNotNull(person2);
            Assert.IsNotNull(ssn);
        }

        [TestMethod]
        public void SSNMatchTest()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.SocialSecurityNumber = "564-82-6341";
            person2.SocialSecurityNumber = "564-82-6341";
            SocialSecurityMatch ssn = new SocialSecurityMatch(person1, person2);
            bool maybe = ssn.Match(person1, person2);
            Assert.IsNotNull(person1);
            Assert.IsNotNull(person2);
            Assert.IsNotNull(ssn);
            Assert.IsTrue(maybe);
        }
    }
}
