using System.ComponentModel.DataAnnotations;

namespace StudentAdministration.Database.Models
{
    public class StudiesProgram
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        public int Credits { get; set; }
        public virtual ICollection<StudiesSubject>? SubjectList { get; set; }
        public virtual ICollection<StudiesSubSubject>? SubSubjectList { get; set; }

    }
}
