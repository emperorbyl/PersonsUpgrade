using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonsUpgrade;

namespace PersonsUpgradeTest
{
    [TestClass]
    public class ConsoleOutputTester
    {
        [TestMethod]
        public void ConsoleOutputConstructorTest()
        {
            ConsoleOutput fileout = new ConsoleOutput();

            fileout.output = new System.IO.StreamWriter(Console.OpenStandardOutput());
            Assert.IsNotNull(fileout);
            Assert.IsNotNull(fileout.output);
            fileout.output.Close();
        }

        [TestMethod]
        public void ConsoleOutDecideTest()
        {
            FileOutput fileout = new FileOutput();
            System.IO.StreamWriter st = new System.IO.StreamWriter(Console.OpenStandardOutput());
            fileout.DecideOutput(st);
            Assert.IsNotNull(fileout);
            Assert.IsNotNull(fileout.output);
            fileout.output.Close();
        }
    }
}
