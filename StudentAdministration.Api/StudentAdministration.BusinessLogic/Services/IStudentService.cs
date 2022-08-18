using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.BusinessLogic.Services
{
    public interface IStudentService
    {
        List<Student>? GetAllStudent();
        ResponseDto SaveStudent(StudentDto studentDto);
        ResponseDto SaveStudentEnroll(EnrollDto enrollDto);
        Student? GetStudentEnroll(string studentPersonalNumber);
    }
}
