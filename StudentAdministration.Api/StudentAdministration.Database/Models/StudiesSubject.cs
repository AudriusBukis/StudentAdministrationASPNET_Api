using System.ComponentModel.DataAnnotations;

namespace StudentAdministration.Database.Models
{
    public class StudiesSubject
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        public int Credits { get; set; }
        public virtual StudiesProgram? StudiesProgram { get; set; }
        public virtual StudiesSubSubject? StudiesSubSubject { get; set; }
    }
}
