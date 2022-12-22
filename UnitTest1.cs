using Factor_TC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace refactor_TC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program a = new Program("sad");
            string expectedResult = "i am sad";
            string actualResult = a.Analyse();

            Assert.AreEqual(expectedResult, actualResult);


        }

        [TestMethod]
        public void TestMethod2()
        {
            Program a = new Program("happy");
            string expectedResult = "happy";
            string actualResult = a.Analyse();

            Assert.AreEqual(expectedResult, actualResult);



        }


    }
}
