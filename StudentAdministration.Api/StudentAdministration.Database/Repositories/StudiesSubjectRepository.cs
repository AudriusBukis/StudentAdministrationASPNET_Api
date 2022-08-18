using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.Database.Repositories
{
    public class StudiesSubjectRepository : IStudiesSubjectRepository
    {
        private readonly ApplicationDbContext _context;
        public StudiesSubjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public StudiesSubject? GetStudiesSubject(string name)
        {
            return _context.StudiesSubject?.FirstOrDefault(subject => subject.Name == name);
        }
        public List<StudiesSubject>? GetAllStudiesSubject()
        {
            return _context.StudiesSubject?.ToList();
        }
        public ResponseDto SaveStudiesSubject(StudiesSubject studiesSubject)
        {
            try
            {
                _context.StudiesSubject?.Add(studiesSubject);
                _context.SaveChanges();
                return new ResponseDto(true, "Studies subject was saved");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
        public ResponseDto ChangeStudiesSubjectCredits(string studiesSubjectName, int creditsNumber)
        {
            try
            {
                var studiesSubject = GetStudiesSubject(studiesSubjectName);
                if (studiesSubject is null)
                    return new ResponseDto(true, "Wrong studies subject name");
                studiesSubject.Credits = creditsNumber;
                _context.SaveChanges();
                return new ResponseDto(true, "Studies subject credits was changed");
            }
            catch (Exception ex)
            {
                return new ResponseDto(false, $"{ex.Message}");
            }
        }
    }
}
