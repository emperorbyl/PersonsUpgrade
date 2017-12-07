using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonsUpgrade;

namespace PersonsUpgradeTest
{
    [TestClass]
    public class NameMatchTester
    {
        [TestMethod]
        public void NameConstructorTest()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            NameMatch name = new NameMatch(person1, person2);
            Assert.IsNotNull(person1);
            Assert.IsNotNull(person2);
            Assert.IsNotNull(name);
        }

        [TestMethod]
        public void NameMatchTest()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Harry";
            person1.MiddleName = "James";
            person1.LastName = "Potter";
            person2.FirstName = "Harry";
            person2.MiddleName = "James";
            person2.LastName = "Potter";
            NameMatch name = new NameMatch(person1, person2);
            bool maybe = name.Match(person1, person2);
            Assert.IsNotNull(person1);
            Assert.IsNotNull(person2);
            Assert.IsNotNull(name);
            Assert.IsTrue(maybe);
        }
    }
}
