using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_02.Inhetitance
{
    internal class Staff: Person
    {
        public string School { get; set;}
        public double Pay {  get; set;}

        public Staff()
        {
            School = "";
        }

        public Staff(string Name, string Address, string School, double Pay):base(Name, Address)
        { 
            this.School = School;
            this.Pay = Pay;
        }
    }
}
