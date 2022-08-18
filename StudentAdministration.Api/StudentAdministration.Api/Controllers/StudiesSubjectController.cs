using Microsoft.AspNetCore.Mvc;
using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.BusinessLogic.Services;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace PersonRegistrationASPNet.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudiesSubjectController : ControllerBase
    {
        
        private readonly IStudiesSubjectService _Service;
        private readonly ILogger<StudiesSubjectController> _logger;
        public StudiesSubjectController(IStudiesSubjectService studiesSubjectService, ILogger<StudiesSubjectController> logger)
        {
            _Service = studiesSubjectService;
            _logger = logger;
        }
        [HttpGet("Get all studies subjects")]
        public List<StudiesSubject>? GetAllStudiesSubject()
        {
            return _Service.GetAllStudiesSubject();
        }
        [HttpPost("Save Studies Subject To Program")]
        public ActionResult<ResponseDto> SaveStudiesSubjectToProgram([FromBody] InputDto inputDto)
        {
            var response = _Service.SaveStudiesSubjectToProgram(inputDto);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpPost("Save Studies Subject To Sub Subject")]
        public ActionResult<ResponseDto> SaveStudiesSubjectToSubSubject([FromBody] InputDto inputDto)
        {
            var response = _Service.SaveStudiesSubjectToSubSubject(inputDto);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
      
    }
}
