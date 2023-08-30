using System.Collections.Generic;

namespace ConsoleCollege.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}