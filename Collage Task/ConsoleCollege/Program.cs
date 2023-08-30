using ConsoleCollege.DAL;
using ConsoleCollege.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCollege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new DataContext();            //(localdb)\MSSQLLocalDB
            //SetData(data);

            //data.Students.ToList().ForEach(student => Console.WriteLine(student.Name));

            //foreach (var teacher in data.Teachers.Include("Students"))
            foreach (var teacher in data.Teachers)
            {
                Console.WriteLine($"Teacher name: {teacher.Name}");

                foreach (var student in teacher.Students)
                {
                    Console.WriteLine($"---- Student: {student.Name}");
                }
            }

        }

        private static void SetData(DataContext data)
        {
            var t1 = new Teacher { Name = "A", Salary = 43.5 };
            var t2 = new Teacher { Name = "B", Salary = 564.4 };
            var t3 = new Teacher { Name = "C", Salary = 72.3 };

            var s1 = new Student { Name = "S1", Grade = 89 };
            var s2 = new Student { Name = "S2", Grade = 92 };
            var s3 = new Student { Name = "S3", Grade = 81 };

            //t1.Students = new Student[] { s1, s2, };
            //t2.Students = new List<Student> { s2, s3 };
            //t3.Students = new LinkedList<Student>();

            t1.Students = new List<Student> { s1, s2, };    // t_id =1 and s_id = 1
            t2.Students = new List<Student> { s2, s3 };
            t3.Students = new List<Student>();

            data.Teachers.Add(t1);
            data.Teachers.Add(t2);
            data.Teachers.Add(t3);

            data.Students.Add(s1);
            data.Students.Add(s2);
            data.Students.Add(s3);

            data.SaveChanges();
        }
    }
}