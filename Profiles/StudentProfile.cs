using AutoMapper;
using MyApiProject.Dtos;
using MyApiProject.Models;

namespace MyApiProject.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Course, CourseDto>().ReverseMap();
        }
    }
}
