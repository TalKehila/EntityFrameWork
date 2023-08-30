using System.Data.Entity;

namespace ConsoleMigration2 {
    internal class Program {
        static void Main(string[] args) {
            var data = new DataContext();

            //SetData(data);
        }

        //private static void SetData(DataContext data) {
        //    data.Customers.Add(new Customer { Name = "First" });
        //    data.Customers.Add(new Customer { Name = "Second" });
        //    data.Customers.Add(new Customer { Name = "Third" });

        //    data.SaveChanges();
        //}
    }

    public class DataContext : DbContext {
        public virtual DbSet<Person> People { get; set; }
    }

    public class Person {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Customer : Person {
        public bool Status { get; set; }
    }
}
