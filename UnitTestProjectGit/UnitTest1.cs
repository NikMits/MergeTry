using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleProject;

namespace UnitTestProjectGit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual(10, Program.sum(3, 7));
        }
        [TestMethod]
        public void TestMult()
        {
            Assert.AreEqual(21, Program.sum(3, 7));
        }
        
    }
}
