using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;
using StudentAdministration.Database.Repositories;

namespace StudentAdministration.BusinessLogic.Services
{
    public class StudiesSubjectService : IStudiesSubjectService
    {
        private readonly IStudiesProgramRepository _studiesProgramRepository;
        private readonly IStudiesSubjectRepository _studiesSubjectRepository;
        private readonly IStudiesSubSubjectRepository _studiesSubSubjectRepository;
        private readonly IMapper _mapper;
        public StudiesSubjectService(IMapper mapper,
                                     IStudiesProgramRepository studiesProgramRepository,
                                     IStudiesSubjectRepository studiesSubjectRepository,
                                     IStudiesSubSubjectRepository studiesSubSubjectRepository)
        {
            _mapper = mapper;
            _studiesProgramRepository = studiesProgramRepository;
            _studiesSubjectRepository = studiesSubjectRepository;
            _studiesSubSubjectRepository = studiesSubSubjectRepository;
        }

        public List<StudiesSubject>? GetAllStudiesSubject()
        {
            return _studiesSubjectRepository.GetAllStudiesSubject();
        }
        public ResponseDto SaveStudiesSubjectToProgram(InputDto inputDto)
        {
            var studiesProgram = _studiesProgramRepository.GetStudiesProgram(inputDto.BelongsToName!);
            var usedCredits = 0;
            if (studiesProgram != null)
            {
                if (studiesProgram.SubjectList != null)
                {
                    foreach (var subject in studiesProgram.SubjectList)
                    {
                        usedCredits += subject.Credits;
                    }
                }
                if (studiesProgram.SubSubjectList != null)
                {
                    foreach (var subSubject in studiesProgram.SubSubjectList)
                    {
                        usedCredits += subSubject.Credits;
                    }
                }
                usedCredits += inputDto.Credits;
                if (studiesProgram.Credits < usedCredits)
                    return new ResponseDto(false, $"New Subject exceeds studies programe credit limit {studiesProgram.Credits - usedCredits} by credits");
                else
                {
                    var newStudiesSubject = _mapper.MapInputDtoToStudiesSubject(inputDto);
                    var response = _studiesSubjectRepository.SaveStudiesSubject(newStudiesSubject);
                    _studiesProgramRepository.AddSubjectToProgram(inputDto.BelongsToName!, newStudiesSubject);
                    return response;
                }
            }
            else
                return new ResponseDto(false, $"Bad program Name");
        }
        public ResponseDto SaveStudiesSubjectToSubSubject(InputDto inputDto)
        {
            var studiesSubSubject = _studiesSubSubjectRepository.GetStudiesSubSubject(inputDto.BelongsToName!);
            var usedCredits = 0;
            if (studiesSubSubject != null)
            {
                if (studiesSubSubject.SubjectsList != null)
                {
                    foreach (var subject in studiesSubSubject.SubjectsList)
                    {
                        usedCredits += subject.Credits;
                    }
                }
                if (studiesSubSubject.SubSubjectListOfSubSubject != null)
                {
                    foreach (var subSubject in studiesSubSubject.SubSubjectListOfSubSubject)
                    {
                        usedCredits += subSubject.Credits;
                    }
                }
                usedCredits += inputDto.Credits;
                if (studiesSubSubject.Credits < usedCredits)
                    return new ResponseDto(false, $"New Subject exceeds studies sub subject credit limit {studiesSubSubject.Credits - usedCredits} by credits");
                else
                {
                    var newStudiesSubject = _mapper.MapInputDtoToStudiesSubject(inputDto);
                    var response = _studiesSubjectRepository.SaveStudiesSubject(newStudiesSubject);
                    _studiesSubSubjectRepository.AddSubjectToSubSubject(inputDto.BelongsToName!, newStudiesSubject);
                    return response;
                }
            }
            else
                return new ResponseDto(false, $"Bad sub subject name");

        }
    }
}
