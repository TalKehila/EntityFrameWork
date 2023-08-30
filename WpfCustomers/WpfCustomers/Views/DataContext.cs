using System.Data.Entity;
using WpfCustomers.Models;

namespace WpfCustomers.Views
{
   
 
        public class DataContext : DbContext
        {
            public virtual DbSet<Customer> Customers { get; set; }

            public DataContext() : base("cus") { }

        }
    
}