using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_02.Inhetitance
{
    internal class Chiled:Parent
    {
        //Attributes
        public int Z {  get; set; }

        //Constructors
        public Chiled()
        {

        }
        public Chiled(int X, int Y, int Z):base(X, Y) 
        {
            this.Z = Z;
        }

        //Method 
        public void Display()
        {
            Console.WriteLine($"X: {X}");
            Console.WriteLine($"Y: {Y}");
            Console.WriteLine($"Z: {Z}");
        }
    }
}
