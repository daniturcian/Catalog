using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogStudenti.Utilities
{
    public class Student
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int YearOfStudying { get; set; }
        public string Group { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {
            Courses = new List<Course>();
        }
    }
    public class Course
    {
        public string CourseName { get; set; }
        public int Grade { get; set; }
        public int CreditNumber { get; set; }
    }

    public class StudentCourseView
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int YearOfStudying { get; set; }
        public string Group { get; set; }
        public string CourseName { get; set; }
        public int Grade { get; set; }
        public int CreditNumber { get; set; }
    }


}
