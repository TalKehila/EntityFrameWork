using System.Collections.Generic;

namespace ConsoleCollege.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }

    //Lazy Loading

    //public class TeacherByEf : Teacher
    //{
    //    private ICollection<Student> students;
    //    public override ICollection<Student> Students
    //    {
    //        get
    //        {
    //            if (students == null)
    //                students = GetStudentsFromDb();   //PROXY (Design Pattern)
    //            return students;
    //        }
    //        set => students = value;
    //    }
    //}
}