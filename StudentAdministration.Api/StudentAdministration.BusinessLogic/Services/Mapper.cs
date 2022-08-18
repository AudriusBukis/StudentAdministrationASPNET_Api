using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.BusinessLogic.Services
{
    public class Mapper : IMapper
    {
        public Student MapStudentDtoToStudent(StudentDto studentDto)
        {
            var newStudent = new Student
                {
                    Id = Guid.NewGuid(),
                    Name = studentDto.Name,
                    LastName = studentDto.LastName,
                    PersonalNumber = studentDto.PersonalNumber
                };
            return newStudent;
        }
        public StudentStudieEnroll MapDataToStudentStudiesEnroll(Student student, StudiesProgram studiesProgram, EnrollDto enrollDto)
        {
            var newStudentStudiesEnroll = new StudentStudieEnroll
            {
                Id = Guid.NewGuid(),
                Student = student,
                Program = studiesProgram,
                EnrollYear = enrollDto.EnrollYear
            };
            return newStudentStudiesEnroll;
        }
        public StudiesProgram MapInputDtoToStudiesProgram(InputDto inputDto)
        {
            var newStudiesProgram = new StudiesProgram
            {
                Id = Guid.NewGuid(),
                Name = inputDto.Name,
                Credits = inputDto.Credits
            };
            return newStudiesProgram;
        }
        public StudiesSubject MapInputDtoToStudiesSubject(InputDto inputDto)
        {
            var newStudiesSubject = new StudiesSubject
            {
                Id = Guid.NewGuid(),
                Name = inputDto.Name,
                Credits = inputDto.Credits
            };
            return newStudiesSubject;
        }
        public StudiesSubSubject MapInputDtoToStudiesSubSubject(InputDto inputDto)
        {
            var newStudiesSubSubject = new StudiesSubSubject
            {
                Id = Guid.NewGuid(),
                Name = inputDto.Name,
                Credits = inputDto.Credits
            };
            return newStudiesSubSubject;
        }
    }
}

