using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_02.Inhetitance
{
    internal class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person() 
        {
            this.Name = string.Empty;
            this.Address = string.Empty;
        }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
