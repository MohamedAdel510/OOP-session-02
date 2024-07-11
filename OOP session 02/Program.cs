using OOP_session_02.Asscosiation_Compositoin;
using OOP_session_02.Inhetitance;
using OOP_session_02.Overriding;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_session_02
{
    internal class Program
    {
        #region polymorphism (Overloading) 
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Sum(int x, int y, int z) // number of parameters
        {
            return x + y + z;
        }

        public static double Sum(double x, double y) // type of parameters
        {
            return x + y;
        }

        public static double Sum(int x, double y)
        {
            return x + y;
        }

        public static double Sum(double x, int y) // order of parameters
        {
            return x + y;
        }
        //Overloading : is a concept in programming that allows us to have more
        //than one function with the same name but different in Signature :
        //➢ Number of parameters , or
        //➢ Types of parameters , or
        //➢ Order of parameters 
        //◇ Note that changing in return type is not considered in overloading, only
        //changing in parameters
        // for example
        //public static double Sum (int x, int y)
        //              ------      -----  -----
        //{
        //    return x + y;
        //}
        //
        #endregion
        static void Main(string[] args)
        {
            #region Constructors and Costructor chaining
            //Car c1 = new Car(1, "Oudi", 250);
            //Console.WriteLine();
            //Car c2 = new Car(2, "MG");
            //Console.WriteLine();
            //Car c3 = new Car(3);
            //Console.WriteLine();
            //Car c4 = new Car();
            //Console.WriteLine();
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            #endregion

            #region Inheritance
            //Parent p1 = new Chiled(4, 5, 6);
            //Chiled c1 = new Chiled(1,2,3);
            //c1.Display();
            #endregion

            #region overloading
            //Console.WriteLine(Sum(1, 2)); // (int, int)
            //Console.WriteLine(Sum(1, 2, 3));// (int , int, int)
            //Console.WriteLine(Sum(3.5, 2.5));// (double, double)
            //Console.WriteLine(Sum(1, 2.5));// (int, double)
            //Console.WriteLine(Sum(1.5, 2));// (double, int)
            #endregion

            #region Overriding
            TypeA A = new TypeA(1);
            A.MyFunc01();
            A.MyFunc02();
            TypeB B = new TypeB(2, 3);
            B.MyFunc01();
            B.MyFunc02();
            #endregion
        }
    }
}
