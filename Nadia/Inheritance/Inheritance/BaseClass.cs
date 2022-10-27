using System;
namespace Inheritance
{
    public class BaseClass
    {
        //overloading is possible in two ways, with number of arguments and with types of argument

        public BaseClass() {
            Console.WriteLine("Base Class Constructor with no parameters");
        }

        public BaseClass(int par1) {
            Console.WriteLine("Base class constructor value is {0}",par1);
        }
        public BaseClass(string par1)
        {
            Console.WriteLine("Base class constructor value is {0}", par1);
        }

        public int bas;
        private int bas2;
        protected int bas3;

        public void setBas(int p1) {
            p1 = bas;
        }
        private void setBas2(int p2)
        {
            p2 = bas2;
        }
        protected void setBas3(int p3)
        {
            bas3 = p3;
        }

        public void GetBase23() {
            Console.WriteLine("Base 2 = {0}, Base 3 = {1}", bas2,bas3);
        }



        /*protected void getInt() {
            bas = 10;
            Console.WriteLine("Value is: {0}", bas);
        }
        public void getProtectedInt() {
            getInt();
        }*/
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass(int par1)//: base( 10) // or public DerivedClass(int par1): base(par1) значення яке передається в derived одразу іде в base
        {
            Console.WriteLine("Derived class constructor value is {0}", par1);
        }
        public void Show() {
            Console.WriteLine("Derived Class String");
        }

        public void getFromTheBaseClass()
        {
            base.bas3 = 20;
            base.setBas3(19);
            base.GetBase23();
        }


    }
}

