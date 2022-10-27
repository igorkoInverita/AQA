using System;

namespace StaticVariablesAndMethods
{
    class Triangle{
        public static int staticInt;
        public int bas;
        public int height;

        public void setValue(int par1) {
            staticInt = par1;
        }

        public void getValue() {
            Console.WriteLine("Value is {0}",staticInt);
        }
        public Triangle(int a, int b) {
            bas = a;
            height = b;
        }
        public static void setStaticValue(int par1) {
            staticInt = par1;
        }
        public static void getStaticValue()
        {
            setStaticValue(1);
            Console.WriteLine("Value is {0}", staticInt);
        }
    }

    //------------------------------------------------------------------------------------------------------------------------------

    class Program
    {
        static void Main(string[] args)
        {
            Triangle obj1 = new Triangle(10,20);
            Triangle.getStaticValue();
            Console.ReadKey();
        }
    }
}

