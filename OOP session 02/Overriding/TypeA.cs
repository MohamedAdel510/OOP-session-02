using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_02.Overriding
{
    internal class TypeA
    {
        public int A {  get; set; }

        public TypeA()
        {
           
        }
        public TypeA(int A)
        {
            this.A = A;
        }

        public void MyFunc01()
        {
            Console.WriteLine("I am a base class");
        }

        public virtual void MyFunc02()
        {
            Console.WriteLine($"TypeA: A{A} ");
        }
    }
}
