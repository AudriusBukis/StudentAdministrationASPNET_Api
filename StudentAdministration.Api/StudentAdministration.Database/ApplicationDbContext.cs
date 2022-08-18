using Microsoft.EntityFrameworkCore;
using StudentAdministration.Database.Models;

namespace StudentAdministration.Database
{
    public class ApplicationDbContext : DbContext 
    {
        public virtual DbSet<Student>? Student { get; set; }
        public virtual DbSet<StudentStudieEnroll>? StudentStudieEnrolls { get; set; }
        public virtual DbSet<StudiesProgram>? StudiesPrograms { get; set; }
        public virtual DbSet<StudiesSubject>? StudiesSubject { get; set; }
        public virtual DbSet<StudiesSubSubject>? StudiesSubSubject { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected ApplicationDbContext()
        {

        }
    }
}
