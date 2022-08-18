using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;
using StudentAdministration.Database.Repositories;


namespace StudentAdministration.BusinessLogic.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IStudiesProgramRepository _studiesProgramRepository;
        private readonly IMapper _mapper;
        public StudentService(IStudentRepository studentRepository, 
                              IMapper mapper, 
                              IStudiesProgramRepository studiesProgramRepository)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
            _studiesProgramRepository = studiesProgramRepository;
        }

        public List<Student>? GetAllStudent()
        {
            return _studentRepository.GetAllStudent();
        }
        public ResponseDto SaveStudent(StudentDto studentDto)
        {
            var student = _studentRepository.GetStudent(studentDto.PersonalNumber!);
            if (student is null)
                return _studentRepository.SaveStudent(_mapper.MapStudentDtoToStudent(studentDto));
            else return new ResponseDto(false, "Student exist in the system");



        }
        public ResponseDto SaveStudentEnroll(EnrollDto enrollDto)
        {
            var studentEnroll = _studentRepository.GetEnroll(enrollDto.StudentPersonalNumber!);
            var newstudentStudiesEnroll = _mapper.MapDataToStudentStudiesEnroll(
                                               _studentRepository.GetStudent(enrollDto.StudentPersonalNumber!)!,
                                               _studiesProgramRepository.GetStudiesProgram(enrollDto.ProgramName!)!,
                                               enrollDto);
            if (studentEnroll is null)
            {
               return _studentRepository.SaveStudentEnroll(newstudentStudiesEnroll);
            }
            var existStudentStudiesEnroll = studentEnroll.FirstOrDefault(x => x.EnrollYear.Equals(enrollDto.EnrollYear) ||
                                           x.Program!.Name!.Equals(enrollDto.ProgramName));
            if (existStudentStudiesEnroll is null)
            {
                return _studentRepository.SaveStudentEnroll(newstudentStudiesEnroll);
            }

            return new ResponseDto(false, "Student sdudies enroll exist");
        }

        public Student? GetStudentEnroll(string studentPersonalNumber)
        {
            var studentEnroll = _studentRepository.GetStudentEnroll(studentPersonalNumber);
            return studentEnroll;
        }
    }
}
