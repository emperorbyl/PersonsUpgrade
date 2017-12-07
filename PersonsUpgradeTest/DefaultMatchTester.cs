using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonsUpgrade;

namespace PersonsUpgradeTest
{
    [TestClass]
    public class DefaultMatchTester
    {
        [TestMethod]
        public void DefaultConstructorTest()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            DefaultMatch @default = new DefaultMatch(person1, person2);
            Assert.IsNotNull(person1);
            Assert.IsNotNull(person2);
            Assert.IsNotNull(@default);
        }

        [TestMethod]
        public void DefaultMatchTest()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.SocialSecurityNumber = "564-82-6341";
            person2.SocialSecurityNumber = "564-82-6341";
            person1 = person2;
            DefaultMatch @default = new DefaultMatch(person1, person2);
            bool maybe = @default.Match(person1, person2);
            Assert.IsNotNull(person1);
            Assert.IsNotNull(person2);
            Assert.IsNotNull(@default);
            Assert.IsTrue(maybe);
        }
    }
}
