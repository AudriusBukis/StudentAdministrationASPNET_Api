using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.BusinessLogic.Services
{
    public interface IStudiesSubSubjectService
    {
        List<StudiesSubSubject>? GetAllStudiesSubSubject();
        ResponseDto SaveStudiesSubSubjectToProgram(InputDto inputDto);
        ResponseDto SaveStudiesSubSubjectToSubSubject(InputDto inputDto);
    }
}
