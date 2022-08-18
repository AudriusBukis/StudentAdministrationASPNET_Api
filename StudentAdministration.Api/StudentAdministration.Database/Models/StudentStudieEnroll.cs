using System.ComponentModel.DataAnnotations;
namespace StudentAdministration.Database.Models
{
    public class StudentStudieEnroll
    {
        public Guid Id { get; set; }
        [Required]
        public virtual Student? Student { get; set; }
        [Required]
        public virtual StudiesProgram? Program { get; set; }
        [Required]
        public int EnrollYear { get; set; }
    }
}
