using Console_CodeFirst.Models;
using System.Collections.Generic;

namespace Console_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new DAL();

            var p1 = new Product { Title = "Best", Price = 54 };
            var p2 = new Product { Title = "Good", Price = 23.5 };
            var p3 = new Product { Title = "Bad", Price = 6.8 };

            var c3 = new Customer { Name = "Third", Status = true, Products = new List<Product>() };

            data.Customers.Add(new Customer { Name = "First", Status = true });
            data.Customers.Add(new Customer { Name = "Second", Products = new List<Product> { p1, p2} });

            c3.Products.Add(p3);

            data.SaveChanges();     //Transaction
        }
    }
}