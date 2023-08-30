using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNorthDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new NorthwindEntities();

            foreach (var customer in data.Customers)
            {
                Console.WriteLine(customer.ContactName);
            }
        }
    }
}
