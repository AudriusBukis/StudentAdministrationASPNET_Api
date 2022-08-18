using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.Database.Repositories
{
    public interface IStudiesSubSubjectRepository
    {
        StudiesSubSubject? GetStudiesSubSubject(string name);
        List<StudiesSubSubject>? GetAllStudiesSubSubject();
        ResponseDto SaveStudiesSubSubject(StudiesSubSubject studiesSubSubject);
        ResponseDto ChangeStudiesSubSubjectCredits(string studiesSubSubjectName, int creditsNumber);
        void AddSubjectToSubSubject(string studiesSubSubjectName, StudiesSubject studiesSubject);
        void AddSubSubjectToSubSubject(string studiesSubSubjectName, StudiesSubSubject studiesSubSubject);
        
    }
}
