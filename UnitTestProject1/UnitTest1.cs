using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Functions func_list;

        public UnitTest1()
        {
            func_list = new Functions();
        }

        [TestMethod]
        public void TestPuissance2()
        {
            long result = func_list.Puissance(100, 2);
            //Console.WriteLine("Testuhskudjhskhds");
            Assert.AreEqual(10000, result);
            //Assert.IsFalse(result, "1 should not be prime");
        }
        [TestMethod]
        public void TestAddition()
        {
            int result = func_list.Addition(1, 2);

            Assert.AreEqual(3, result);
            //Assert.IsFalse(result, "1 should not be prime");
        }

        [TestMethod]
        public void TestSoustraction()
        {
            int result = func_list.Soustraction(5, 2);

            Assert.AreEqual(3, result);
            //Assert.IsFalse(result, "1 should not be prime");
        }

        //[TestMethod]
        //public void TestPuissance(int a, int b, long c)
        //{
        //    long result = func_list.Puissance(a, b);
        //    Assert.AreEqual(c, result);
        //    //Assert.IsFalse(result, "1 should not be prime");
        //}

        
    }
}
