using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest1
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void BeforeClass(TestContext tc)
        {
            Console.WriteLine("Before calss.");
        }

        [ClassCleanup(InheritanceBehavior.None)]
        public static void AfterClass()
        {
            Console.WriteLine("After calss.");
        }

        [TestInitialize]
        public void BeforeTest() {
            Console.WriteLine("Before method.");
        }

        [TestCleanup]
        public void AfterTest() {
            Console.WriteLine("After method.");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Ababahalamaga!");
        }
    }
}

