using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {

        private readonly Functions func_list;

        public UnitTest2()
        {
            func_list = new Functions();
        }

        [TestMethod]
        public void TestPuissanceuNITtEST2()
        {
            long result = func_list.Puissance(3, 3);
            Assert.AreEqual(237, result, "eRREUR / TestPuissanceuNITtEST2");
            //Assert.IsFalse(result, "1 should not be prime");
        }

        [TestMethod]
        public void TestMethod1()
        {
            long result = func_list.Puissance(3, 3);
            Assert.AreEqual(237, result, "eRREUR / TestMethod1");
        }


    }
}
