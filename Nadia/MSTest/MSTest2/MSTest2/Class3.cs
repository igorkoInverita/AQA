using System;
namespace MSTest2
{
    [TestClass]
    public class Class3
    {
        [TestMethod,TestCategory("Smoke")]
        public void Test() {
            Console.WriteLine("Test Class 3");
        }
    }
}

