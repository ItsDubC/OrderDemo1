using Autofac;
using OrderDemo1.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDemo1
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Customer>().As<ICustomer>();
            builder.RegisterType<LineItem>().As<ILineItem>();
            builder.RegisterType<Order>().As<IOrder>();
            builder.RegisterType<Product>().As<IProduct>();

            Container = builder.Build();
        }
    }
}
