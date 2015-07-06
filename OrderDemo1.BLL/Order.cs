using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo1.BLL
{
    public class Order
    {
        public Customer Customer { get; set; }
        public List<LineItem> LineItems { get; set; }
        public decimal TotalCost { get; set; }

        public Order() {}

        public Order(Customer customer, List<LineItem> lineItems)
        {
            Customer = customer;
            LineItems = lineItems;
        }
    }
}
