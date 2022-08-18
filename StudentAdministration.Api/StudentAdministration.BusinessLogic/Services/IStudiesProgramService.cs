using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace StudentAdministration.BusinessLogic.Services
{
    public interface IStudiesProgramService
    {
        List<StudiesProgram>? GetAllStudiesProgram();
        ResponseDto SaveStudiesProgram(InputDto inputDto);
    }
}
