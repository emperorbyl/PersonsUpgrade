using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonsUpgrade;

namespace PersonsUpgradeTest
{
    [TestClass]
    public class PersonMatcherTest
    {
        [TestMethod]
        public void TestMatchPairConstructor()
        {
            Person personA = new Person();
            Person personB = new Person();
            MatchPair match = new MatchPair(personA, personB);
            Assert.IsNotNull(match);
        }
    }
}
