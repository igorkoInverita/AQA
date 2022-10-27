using System;
namespace MSTest2
{
    [TestClass]
    public class Class1
    {
        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext tc)
        {
            Console.WriteLine("Before Assembly");
        }
        [AssemblyCleanup]
        public static void BAfterAssembly(
            )
        {
            Console.WriteLine("After Assembly");
        }
    }
}

