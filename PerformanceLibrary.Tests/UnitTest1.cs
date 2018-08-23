using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerformanceLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestConcatenate()
        {
            var result = PerformanceLibrary.Class1.TightLoopConcatenate();

            TestContext.WriteLine($"Resulting text length is {result.Length}");
            Assert.AreEqual(200000, result.Length);
        }

        [TestMethod]
        public void TestStringBuilder()
        {
            var result = PerformanceLibrary.Class1.TightLoopStringBuilder();

            TestContext.WriteLine($"Resulting text length is {result.Length}");
            Assert.AreEqual(200000, result.Length);
        }
    }
}
