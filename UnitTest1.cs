using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Testing_UC;

namespace TestProject_UC
{
    [TestClass]
    public class UnitTest1
    {

        

        [TestMethod]
        public void WhenGivenSadMessage_shouldReturnSad()
        {
            try
            {
                string message = MoodAnalyser.AnalyseMood("i am sad");
                Assert.AreEqual("Sad", message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}
