using System.ComponentModel.DataAnnotations;

namespace StudentAdministration.BusinessLogic.DTOs
{
    public class InputDto
    {
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        public int Credits { get; set; }
        [MaxLength(50)]
        public string? BelongsToName { get; set; }
    }
}
