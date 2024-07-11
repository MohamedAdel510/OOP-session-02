using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_02.Overriding
{
    internal class TypeB:TypeA
    {
        public int B {  get; set; }

        public TypeB() { }
        public TypeB(int A, int B):base(A)
        { 
            this.B = B; 
        }

        // overriding using new keyword
        public new void MyFunc01()
        {
            Console.WriteLine("I am a child class");
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"TypeA: A{A}\nTypeB: B{B}");
        }
    }
}
