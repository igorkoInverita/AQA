using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass der = new DerivedClass(7);
            //der.getProtectedInt();
            //der.Show();
            der.GetBase23();
            der.Show();
        }
    }
}

