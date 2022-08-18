using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;
using StudentAdministration.Database.Repositories;

namespace StudentAdministration.BusinessLogic.Services
{
    public class StudiesProgramService : IStudiesProgramService
    {
        private readonly IStudiesProgramRepository _studiesProgramRepository;
        private readonly IMapper _mapper;
        public StudiesProgramService(IMapper mapper,
                              IStudiesProgramRepository studiesProgramRepository)
        {
            _mapper = mapper;
            _studiesProgramRepository = studiesProgramRepository;
        }
        public List<StudiesProgram>? GetAllStudiesProgram()
        {
            return _studiesProgramRepository.GetAllStudiesProgram();
        }
        public ResponseDto SaveStudiesProgram(InputDto inputDto)
        {
            var studiesProgram = _studiesProgramRepository.GetStudiesProgram(inputDto.Name!);
            if (studiesProgram is null)
                return _studiesProgramRepository.SaveStudiesProgram(_mapper.MapInputDtoToStudiesProgram(inputDto));
            else return new ResponseDto(false, "Program with this name exist");

        }
    }
}
