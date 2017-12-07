using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonsUpgrade;

namespace PersonsUpgradeTest
{
    [TestClass]
    public class PersonMatcherTest
    {
        [TestMethod]
        public void PersonMatcherConstructorTest()
        {
            Person personA = new Person();
            Person personB = new Person();
            personA.SocialSecurityNumber = "652-48-9546";
            personB.SocialSecurityNumber = "652-48-9546";
            PersonMatcher person = new PersonMatcher();
            person.algorithmName = "mom";
            person.filename = "Test/Test.xml";
            person.outputFile = "Results.xml";
            person.matchList.Add(new SocialSecurityMatch(personA, personB));
            Assert.IsNotNull(person);
            Assert.IsNotNull(personA);
            Assert.IsNotNull(personB);
            Assert.IsNotNull(person.algorithmName);
            Assert.IsNotNull(person.filename);
            Assert.IsNotNull(person.outputFile);
            Assert.IsNotNull(person.matchList);
            Assert.AreEqual("mom", person.algorithmName);
            Assert.AreEqual("Test/Test.xml", person.filename);
            Assert.AreEqual("Results.xml", person.outputFile);
            Assert.AreEqual(1, person.matchList.Count);
        }
    }
}
