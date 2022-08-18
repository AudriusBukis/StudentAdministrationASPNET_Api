using System.ComponentModel.DataAnnotations;

namespace StudentAdministration.Database.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string? LastName { get; set; }
        [Required]
        [MaxLength(11)]
        public string? PersonalNumber { get; set; }
        public virtual ICollection<StudentStudieEnroll>? StudentStudieEnrolls { get; set; }

    }
}
