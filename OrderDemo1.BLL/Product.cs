using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo1.BLL
{
    public interface IProduct {}

    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public Product() {}

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
