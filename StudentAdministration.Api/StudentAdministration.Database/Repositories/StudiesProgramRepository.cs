using Microsoft.EntityFrameworkCore;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.Database.Repositories
{
    public class StudiesProgramRepository : IStudiesProgramRepository
    {
        private readonly ApplicationDbContext _context;

        public StudiesProgramRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public StudiesProgram? GetStudiesProgram(string name)
        {
            return _context.StudiesPrograms?.Include(i => i.SubjectList).
                                             Include(i => i.SubSubjectList).
                                             FirstOrDefault(program => program.Name == name);
        }
        public List<StudiesProgram>? GetAllStudiesProgram()
        {
            return _context.StudiesPrograms?.ToList();
        }
        public ResponseDto SaveStudiesProgram(StudiesProgram studiesPrograme)
        {
            try
            {
                _context.StudiesPrograms?.Add(studiesPrograme);
                _context.SaveChanges();
                return new ResponseDto(true, "Studies program was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
           
        }
        public void AddSubjectToProgram(string studiesProgramName, StudiesSubject studiesSubject)
        {
            var studiesProgram = _context.StudiesPrograms?.FirstOrDefault(i => i.Name == studiesProgramName);
            studiesProgram!.SubjectList!.Add(studiesSubject);
            _context.SaveChanges();
        }
        public void AddSubSubjectToProgram(string studiesProgramName, StudiesSubSubject studiesSubSubject)
        {
            var studiesProgram = _context.StudiesPrograms?.FirstOrDefault(i => i.Name == studiesProgramName);
            studiesProgram!.SubSubjectList!.Add(studiesSubSubject);
            _context.SaveChanges();
        }
    }
}
