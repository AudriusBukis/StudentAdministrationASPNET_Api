using System.ComponentModel.DataAnnotations;

namespace StudentAdministration.Database.Models
{
    public class StudiesSubSubject
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        public int Credits { get; set; }
        public virtual ICollection<StudiesSubSubject>? SubSubjectListOfSubSubject { get; set; }
        public virtual ICollection<StudiesSubject>? SubjectsList { get; set; }
    }
}
