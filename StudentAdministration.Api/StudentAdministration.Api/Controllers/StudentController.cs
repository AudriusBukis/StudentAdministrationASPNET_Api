using Microsoft.AspNetCore.Mvc;
using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.BusinessLogic.Services;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace PersonRegistrationASPNet.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        
        private readonly IStudentService _Service;
        private readonly ILogger<StudentController> _logger;
        public StudentController(IStudentService studentService, ILogger<StudentController> logger)
        {
            _Service = studentService;
            _logger = logger;
        }
        [HttpGet("GetAllSudents")]
        public List<Student>? GetAllSudents()
        {
            return _Service.GetAllStudent();
        }
        [HttpGet("GetStudentEnroll")]
        public Student? GetSudentEnroll([FromQuery] string studentPersonalNumber)
        {
            var response = _Service.GetStudentEnroll(studentPersonalNumber);
            return response;
        }
        [HttpPost("AddStudent")]
        public ActionResult<ResponseDto> AddStudent([FromBody] StudentDto studentDto)
        {
           
            var response = _Service.SaveStudent(studentDto);
            if (!response.IsSuccess)
                return BadRequest(response);
            return response;
        }
        [HttpPost("AddStudentEnroll")]
        public ActionResult<ResponseDto> AddStudentEnroll([FromBody] EnrollDto enrollDto)
        {
            var response = _Service.SaveStudentEnroll(enrollDto);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
    }
}
