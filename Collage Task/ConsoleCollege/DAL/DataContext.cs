using ConsoleCollege.Models;
using System.Data.Entity;

namespace ConsoleCollege.DAL
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        public DataContext() : base("College") { }
    }
}