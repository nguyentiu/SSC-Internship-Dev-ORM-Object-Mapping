namespace MyApiProject.Dtos
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public TeacherDto Teacher { get; set; }
    }

}
