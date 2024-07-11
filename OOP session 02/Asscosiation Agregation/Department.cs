using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_02.Asscosiation_Agregation
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee[]? Employees { get; set; }

        public Department() 
        { 
            this.Name = string.Empty;
        }


    }
}
