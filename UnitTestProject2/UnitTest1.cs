using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        

        private readonly Functions func_list;
        private FactorialTester funcTester_list;

        public UnitTest1()
        {
            func_list = new Functions();
            
        }

        [TestMethod]
        public void TestFactorielle_3_6()
        {
            funcTester_list = new FactorialTester();
            long result = func_list.ResultFactorielle(3);
            Assert.AreEqual(6, result, "TestFactorielle_3_6_False");
        }

        [TestMethod]
        public void TestFactorielle_4_24()
        {
            funcTester_list = new FactorialTester();
            long result = func_list.Factorielle(4);
            Assert.AreEqual(24, result, "TestFactorielle_4_24_True");
        }

        [TestMethod]
        public void TestPuissance2()
        {
            long result = func_list.Puissance(100, 2);
            //Console.WriteLine("Testuhskudjhskhds");
            Assert.AreEqual(10000, result, "TestPuissance2");
            //Assert.IsFalse(result, "1 should not be prime");
        }

        [TestMethod]
        public void TestAddition()
        {
            int result = func_list.Addition(1, 2);

            Assert.AreEqual(3, result, "TestAddition");
            //Assert.IsFalse(result, "1 should not be prime");
        }

        [TestMethod]
        public void TestSoustraction()
        {
            int result = func_list.Soustraction(5, 2);

            Assert.AreEqual(3, result, "TestSoustraction");
            //Assert.IsFalse(result, "1 should not be prime");
        }

        // Testing
        [TestMethod]
        public void IsCalledAtLeastOnce()
        {
            funcTester_list = new FactorialTester();
            funcTester_list.Factorielle(1);
            Assert.AreNotSame(1, funcTester_list.NumberOfCalls);
        }
        [TestMethod]
        public void IsCalled3TimesForNumber3()
        {
            funcTester_list = new FactorialTester();
            funcTester_list.Factorielle(3);
            Assert.AreEqual(3, funcTester_list.NumberOfCalls);
        }

    }
}
