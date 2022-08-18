using System.ComponentModel.DataAnnotations;

namespace StudentAdministration.BusinessLogic.DTOs
{
    public class EnrollDto
    {
        [Required]
        [MaxLength(11)]
        public string? StudentPersonalNumber { get; set; }
        [Required]
        public string? ProgramName { get; set; }
        [Required]
        public int EnrollYear { get; set; }

    }
}
