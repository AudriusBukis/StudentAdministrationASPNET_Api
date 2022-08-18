using Microsoft.AspNetCore.Mvc;
using StudentAdministration.BusinessLogic.DTOs;
using StudentAdministration.BusinessLogic.Services;
using StudentAdministration.Database.DTOs;
using StudentAdministration.Database.Models;

namespace PersonRegistrationASPNet.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudiesProgramController : ControllerBase
    {
        
        private readonly IStudiesProgramService _Service;
        private readonly ILogger<StudiesProgramController> _logger;
        public StudiesProgramController(IStudiesProgramService studiesProgramService, ILogger<StudiesProgramController> logger)
        {
            _Service = studiesProgramService;
            _logger = logger;
        }
        [HttpGet("Get All Studies Program")]
        public List<StudiesProgram> GetAllStudiesProgram()
        {
            return _Service.GetAllStudiesProgram()!;
        }
        [HttpPost("Add Studies Program")]
        public ActionResult<ResponseDto> SaveStudiesProgram([FromBody] InputDto inputDto)
        {
            var response = _Service.SaveStudiesProgram(inputDto);
            if (!response.IsSuccess)
                return BadRequest(response.Message);
            return response;
        }
    }
}
