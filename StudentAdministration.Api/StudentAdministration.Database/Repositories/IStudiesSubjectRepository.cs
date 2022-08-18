using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.Database.Repositories
{
    public interface IStudiesSubjectRepository
    {
        StudiesSubject? GetStudiesSubject(string name);
        List<StudiesSubject>? GetAllStudiesSubject();
        ResponseDto SaveStudiesSubject(StudiesSubject studiesSubject);
        ResponseDto ChangeStudiesSubjectCredits(string studiesSubjectName, int creditsNumber);
        
    }
}
