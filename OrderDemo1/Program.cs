using Autofac;
using OrderDemo1.BLL;
using OrderDemo1.DAL;
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
        private static IRepository<Customer> _customerRepo;
        private static IRepository<Order> _orderRepo;

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Customer>().As<ICustomer>();
            builder.RegisterType<LineItem>().As<ILineItem>();
            builder.RegisterType<Order>().As<IOrder>();
            builder.RegisterType<Product>().As<IProduct>();

            Container = builder.Build();

            _customerRepo = new Repository<Customer>();
            _customerRepo.Add(new Customer { FirstName = "Chris", LastName = "Cais" });
            _customerRepo.Add(new Customer { FirstName = "James", LastName = "Harden" });
            _customerRepo.Save();


        }
    }
}
