using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.Database.Repositories
{
    public interface IStudiesProgramRepository
    {
        StudiesProgram? GetStudiesProgram(string name);
        List<StudiesProgram>? GetAllStudiesProgram();
        ResponseDto SaveStudiesProgram(StudiesProgram studiesPrograme);
        void AddSubjectToProgram(string studiesProgramName, StudiesSubject studiesSubject);
        void AddSubSubjectToProgram(string studiesProgramName, StudiesSubSubject studiesSubSubject);
    }
}
