using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TC_uc_2;

namespace TC_UC_2._1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod6()
        {
            
           // string expected = "happy";
            mood moodAnalyser = new mood("null");
            string expected = "happy";
            string Actual = moodAnalyser.analyse();

            Assert.AreEqual(expected, Actual);

        }
    }
}
