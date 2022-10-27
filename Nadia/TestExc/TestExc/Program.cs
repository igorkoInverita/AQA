using System;

namespace TestExc
{
    class Program
    {
        public class BaseClass {
            //private string data;

            public string Data1 { get; set; }

            //public string Data {

            //    get {
            //        //data = data + "Extra string settled on getter.";
            //        return data;
            //    }
            //    set {
                    
            //        //data = value;
            //        data = data + "Extra string settled on setter.";
            //    }

            //}

            

            public void Show(string str1) {
               
                try
                {
                    Console.WriteLine("String is {0}", str1);
                    //throw new UserDefineException("Test string.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    Console.WriteLine("Filally block.");

                }
                
            }
        }

        public class UserDefineException : Exception {

            public UserDefineException(string str) : base(str) {
                Console.WriteLine("User defined exception.");
            }
        }
        


        static void Main(string[] args)
        {

            BaseClass obj1 = new BaseClass();
            //obj1.Show("Test");
            obj1.Data1 = "Test";
            Console.WriteLine("Test QA {0}",obj1.Data1);


        }
    }
}

