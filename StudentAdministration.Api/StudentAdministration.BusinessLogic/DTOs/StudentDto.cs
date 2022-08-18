using StudentAdministration.BusinessLogic.Attributes;
using System.ComponentModel.DataAnnotations;

namespace StudentAdministration.BusinessLogic.DTOs
{
    public class StudentDto
    {
        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string? LastName { get; set; }
        [Required]
        [MaxLength(11)]
        [MinLength(11)]
        [OnlyNumbers]
        [ChechWhiteSpaces]
        public string? PersonalNumber { get; set; }
    }
}
