using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo1.BLL
{
    public interface ILineItem { }

    public class LineItem : ILineItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public LineItem() {}
    }
}
