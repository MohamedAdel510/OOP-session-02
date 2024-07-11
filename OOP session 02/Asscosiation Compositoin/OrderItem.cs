using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_02.Asscosiation_Compositoin
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public decimal price {  get; set; }
        public int quantity { get; set; }

        public OrderItem(Product product)
        {
            this.Product = product;
        }
    }
}
