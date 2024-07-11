using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_02.Asscosiation_Compositoin
{
    internal class Order
    {
        public int Id {  get; set; }
        public string BuyerEmail { get; set; }

        public decimal SubTotal {  get; set; }
        public OrderItem[] Items { get; set; }

        public Order(string BuyerEmail, OrderItem[] Items)
        {
            this.BuyerEmail = BuyerEmail;
            this.Items = Items;
        }
    }
}
