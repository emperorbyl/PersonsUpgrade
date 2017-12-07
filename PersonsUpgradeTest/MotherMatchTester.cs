using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonsUpgrade;

namespace PersonsUpgradeTest
{
    [TestClass]
    public class MotherMatchTester
    {
        [TestMethod]
        public void MotherConstructorTest()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            MotherMatch mom = new MotherMatch(person1, person2);
            Assert.IsNotNull(person1);
            Assert.IsNotNull(person2);
            Assert.IsNotNull(mom);
        }

        [TestMethod]
        public void MotherMatchTest()
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.MotherFirstName = "Hermonie";
            person1.MotherMiddleName = "Jean";
            person1.MotherLastName = "Granger";
            person2.MotherFirstName = "Hermonie";
            person2.MotherMiddleName = "Jean";
            person2.MotherLastName = "Granger";
            MotherMatch mom = new MotherMatch(person1, person2);
            bool maybe = mom.Match(person1, person2);
            Assert.IsNotNull(person1);
            Assert.IsNotNull(person2);
            Assert.IsNotNull(mom);
            Assert.IsTrue(maybe);
        }
    }
}
