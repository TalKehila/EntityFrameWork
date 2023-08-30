using ConsoleClosing.Models;
using System.Data.Entity;

namespace ConsoleClosing.Dal {
    public class DataContext : DbContext {
        public virtual DbSet<Dress> Dresses { get; set; }

        public DataContext() : base("Clothing") { }
    }
}