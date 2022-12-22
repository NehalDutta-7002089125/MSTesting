using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyse;

namespace MoodAnalyse
{
    [TestClass]
    public class UnitTest1
    {
       

        [TestMethod]
        public void TestMethod1()
        {
            Program a = new Program();
          
              string mood =a.Analyse("sad");
           
            Assert.AreEqual(mood,"sad");


        }
        [TestMethod]

        public void TestMethod2()
        {
            Program b = new Program();

            string mood = b.Analyse("i happy");

            Assert.AreEqual(mood, "i happy");


        }

    }
}
