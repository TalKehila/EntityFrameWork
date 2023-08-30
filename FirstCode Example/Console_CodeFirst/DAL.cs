using Console_CodeFirst.Models;
using System.Data.Entity;

namespace Console_CodeFirst
{
    //DAL = Data Access Layer
    public class DAL : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        public DAL() : base("MyNameData") {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DAL>());
        }
    }
}