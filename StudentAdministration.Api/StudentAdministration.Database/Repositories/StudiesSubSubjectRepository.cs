using Microsoft.EntityFrameworkCore;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.Database.Repositories
{
    public class StudiesSubSubjectRepository : IStudiesSubSubjectRepository
    {
        private readonly ApplicationDbContext _context;
        public StudiesSubSubjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public StudiesSubSubject? GetStudiesSubSubject(string name)
        {
            return _context.StudiesSubSubject?.Include(i => i.SubjectsList).
                                               Include(i => i.SubSubjectListOfSubSubject).
                                               FirstOrDefault(subject => subject.Name == name);
        }
        public List<StudiesSubSubject>? GetAllStudiesSubSubject()
        {
            return _context.StudiesSubSubject?.ToList();
        }
        public ResponseDto SaveStudiesSubSubject(StudiesSubSubject studiesSubSubject)
        {
            try
            {
                _context.StudiesSubSubject?.Add(studiesSubSubject);
                _context.SaveChanges();
                return new ResponseDto(true, "Studies sub subject was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto ChangeStudiesSubSubjectCredits(string studiesSubSubjectName, int creditsNumber)
        {
            try
            {
                var studiesSubject = GetStudiesSubSubject(studiesSubSubjectName);
                if (studiesSubject is null)
                    return new ResponseDto(true, "Wrong studies sub subject name");
                studiesSubject.Credits = creditsNumber;
                _context.SaveChanges();
                return new ResponseDto(true, "Studies sub subject credits was changed");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public void AddSubjectToSubSubject(string studiesSubSubjectName, StudiesSubject studiesSubject)
        {
            var studiesSubSbject = _context.StudiesSubSubject?.FirstOrDefault(i => i.Name == studiesSubSubjectName);
            studiesSubSbject?.SubjectsList?.Add(studiesSubject);
            _context.SaveChanges();
        }
        public void AddSubSubjectToSubSubject(string studiesSubSubjectName, StudiesSubSubject studiesSubSubject)
        {
            var studiesSubSbject = _context.StudiesSubSubject?.FirstOrDefault(i => i.Name == studiesSubSubjectName);
            studiesSubSbject?.SubSubjectListOfSubSubject?.Add(studiesSubSubject);
            _context.SaveChanges();
        }

    }
}
