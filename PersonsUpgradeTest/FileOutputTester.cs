using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonsUpgrade;

namespace PersonsUpgradeTest
{
    [TestClass]
    public class FileOutputTester
    {
        private string file = @"C:\Users\benja\OneDrive\Documentos\GitHub\CS5700\PersonsUpgrade\PersonsUpgradeTest\XML_PersonTestSet_1.xml";
        [TestMethod]
        public void FileOutputConstructorTest()
        {
            FileOutput fileout = new FileOutput();
            
            fileout.output = new System.IO.StreamWriter(file);
            Assert.IsNotNull(fileout);
            Assert.IsNotNull(fileout.output);
            fileout.output.Close();
        }

        [TestMethod]
        public void FileOutDecideTest()
        {
            FileOutput fileout = new FileOutput();
            System.IO.StreamWriter st = new System.IO.StreamWriter(file);
            fileout.DecideOutput(st);
            Assert.IsNotNull(fileout);
            Assert.IsNotNull(fileout.output);
            fileout.output.Close();
        }
    }
}
