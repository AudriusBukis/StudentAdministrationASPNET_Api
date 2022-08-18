using Microsoft.EntityFrameworkCore;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.Database.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Student? GetStudent(string personalNumber)
        {
            return _context.Student?.FirstOrDefault(student => student.PersonalNumber == personalNumber);
        }
        public List<Student>? GetAllStudent()
        {
            return _context.Student?.ToList();
        }
        public ResponseDto SaveStudent(Student student)
        {
            try
            {
                _context.Student?.Add(student);
                _context.SaveChanges();
                return new ResponseDto(true, "Sudent was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto SaveStudentEnroll(StudentStudieEnroll studentStudieEnroll)
        {
            try
            {
                _context.StudentStudieEnrolls?.Add(studentStudieEnroll);
                _context.SaveChanges();
                return new ResponseDto(true, "Sudent studies enroll was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }

        public List<StudentStudieEnroll>? GetEnroll(string studentPersonalNumber)
        {
              return _context.StudentStudieEnrolls?.Include(i => i.Student).
                                                    Include(i => i.Program).
                                                    Where(x => x.Student!.PersonalNumber == studentPersonalNumber).
                                                    ToList();
        }
        public Student? GetStudentEnroll(string studentPersonalNumber)
        {
            return _context.Student?.Include(i => i.StudentStudieEnrolls)!.
                                     ThenInclude(s => s.Program).
                                     ThenInclude(program => program!.SubjectList).
                                     Include(i => i.StudentStudieEnrolls)!.
                                     ThenInclude(s => s.Program).
                                     ThenInclude(p => p!.SubSubjectList)!.
                                     ThenInclude(s => s.SubjectsList).
                                     Include(i => i.StudentStudieEnrolls)!.
                                     ThenInclude(s => s.Program).
                                     ThenInclude(p => p!.SubSubjectList)!.
                                     ThenInclude(s => s.SubSubjectListOfSubSubject)!.
                                     ThenInclude(s => s.SubjectsList).
                                     FirstOrDefault(x => x.PersonalNumber == studentPersonalNumber);
                                     
        }


    }
}
