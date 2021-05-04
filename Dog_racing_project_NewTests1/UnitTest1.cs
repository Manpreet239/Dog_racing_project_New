using Dog_racing_project_New;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dog_racing_project_NewTests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Player obj = new Player("Henry", 20, 4, 100);
            if (obj.restResult(4) == 120)
            {
                Assert.IsTrue(true);
            }
            else {

                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            Player obj = new Player("Smith", 10, 3, 100);
            if (obj.restResult(3) == 110)
            {
                Assert.IsTrue(true);

            }
            else
            {

                Assert.IsTrue(false);
            }
        }
    }
}
