using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_02.Asscosiation_Agregation
{
    internal class Employee
    {
       public int Id { get; set; }  
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address {  get; set; }

        public Employee()
        {
            Name = string.Empty;
            Address = string.Empty;
        }
    }
}
