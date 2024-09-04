using MyApiProject.Dtos;
using MyApiProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApiProject.Services
{
    public interface IStudentService
    {
        Task<Student> AddStudentAsync(Student student);
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student> GetStudentByIdAsync(int id);
        Task<IEnumerable<Course>> GetCoursesByStudentIdAsync(int studentId);
        Task UpdateStudentAsync(Student student);
        Task DeleteStudentAsync(int id);
    }
}
