using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_02.Inhetitance
{
    internal class Student:Person
    {
        public string Program { get; set; }

        public int Year { get; set; }

        public double Fee {  get; set; }

        public Student() 
        {
            Program = string.Empty;
        }

        public Student(string Name, string Address, string Program, int Year, double Fee): base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }
    }
}
