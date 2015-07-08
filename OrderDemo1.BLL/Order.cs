using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo1.BLL
{
    public interface IOrder { }

    public class Order : IOrder
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
        public decimal TotalCost { get; set; }

        public Order() {}

        public Order(Customer customer, ICollection<LineItem> lineItems)
        {
            Customer = customer;
            LineItems = lineItems;
        }
    }
}
