using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeA
    {
        private protected int X { get; set; } // => private

        protected int Y { get; set; }
        // Accessable only in the same class or inherited class as (private)

        internal protected int Z { get; set; }
        // Accessable int the same class or inherited class that is in the same or (different project)
    }
}
