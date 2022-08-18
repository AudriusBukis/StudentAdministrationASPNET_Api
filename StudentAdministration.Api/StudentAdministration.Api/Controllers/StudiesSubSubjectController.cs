using Microsoft.AspNetCore.Mvc;
using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.BusinessLogic.Services;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace PersonRegistrationASPNet.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudiesSubSubjectController : ControllerBase
    {
        
        private readonly IStudiesSubSubjectService _service;
        private readonly ILogger<StudiesSubSubjectController> _logger;
        public StudiesSubSubjectController(IStudiesSubSubjectService studiesSubSubjectService, ILogger<StudiesSubSubjectController> logger)
        {
            _service = studiesSubSubjectService;
            _logger = logger;
        }
        [HttpGet("Get All Studies Sub Subject")]
        public List<StudiesSubSubject>? GetAllStudiesSubSubject()
        {
            return _service.GetAllStudiesSubSubject();
        }
        [HttpPost("Save Studies Sub Subject To Program")]
        public ActionResult<ResponseDto> SaveStudiesSubSubjectToProgram([FromBody] InputDto inputDto)
        {
            var response = _service.SaveStudiesSubSubjectToProgram(inputDto);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
        [HttpPost("Save Studies Sub Subject To Sub Subject")]
        public ActionResult<ResponseDto> SaveStudiesSubSubjectToSubSubject([FromBody] InputDto inputDto)
        {
            var response = _service.SaveStudiesSubSubjectToSubSubject(inputDto);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
       
    }
}
