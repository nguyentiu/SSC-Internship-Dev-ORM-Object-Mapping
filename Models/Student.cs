using System.Collections.Generic;

namespace MyApiProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
