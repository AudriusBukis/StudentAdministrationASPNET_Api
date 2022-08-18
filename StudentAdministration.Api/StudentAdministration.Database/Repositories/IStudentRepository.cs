using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.Database.Repositories
{
    public interface IStudentRepository
    {
        Student? GetStudent(string personalNumber);
        List<Student>? GetAllStudent();
        ResponseDto SaveStudent(Student student);
        ResponseDto SaveStudentEnroll(StudentStudieEnroll studentStudieEnroll);
        List<StudentStudieEnroll>? GetEnroll(string studentPersonalNumber);
        Student? GetStudentEnroll(string studentPersonalNumber);
    }
}
