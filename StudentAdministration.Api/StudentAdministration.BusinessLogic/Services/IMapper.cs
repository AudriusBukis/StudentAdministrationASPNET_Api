using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.BusinessLogic.Services
{
    public interface IMapper
    {
        Student MapStudentDtoToStudent(StudentDto studentDto);
        StudentStudieEnroll MapDataToStudentStudiesEnroll(Student student, StudiesProgram studiesProgram, EnrollDto enrollDto);
        StudiesProgram MapInputDtoToStudiesProgram(InputDto inputDto);
        StudiesSubject MapInputDtoToStudiesSubject(InputDto inputDto);
        StudiesSubSubject MapInputDtoToStudiesSubSubject(InputDto inputDto);
    }
}
