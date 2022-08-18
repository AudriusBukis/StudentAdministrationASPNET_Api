using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.BusinessLogic.Services
{
    public interface IStudiesSubjectService
    {
        List<StudiesSubject>? GetAllStudiesSubject();
        ResponseDto SaveStudiesSubjectToProgram(InputDto inputDto);
        ResponseDto SaveStudiesSubjectToSubSubject(InputDto inputDto);

    }
}
