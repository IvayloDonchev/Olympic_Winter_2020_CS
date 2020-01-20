using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olympic_Winter_2020;

namespace UnitTest_Olympics
{
    [TestClass]
    public class Olympic_Tests
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            var res = Olympic_Winter_2020.Program.Calculate("128 33");
            Assert.AreEqual(res, "156 216");
            res = Olympic_Winter_2020.Program.Calculate("5638 638");
            Assert.AreEqual(res, "6266 6376");
        }
    }
}
