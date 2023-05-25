using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Schedule.Models.ReferenceBooksModule;
using Schedule.Models.ReferenceBookModule;
using Schedule.Models.ContingentModule;
using Schedule.Models.GeneralModule;



namespace Schedule.Context
{
    public class MainContext : DbContext
    {
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<SpecialityFormOfStudy> SpecialityFormOfStudy { get; set; }
        public DbSet<SubjectSpecialityFormOfStudy> SubjectSpecialityFormOfStudy { get; set; }
        public DbSet<TeacherSubject> TeacherSubject { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<AcademicYear> AcademicYear { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Speciality> Speciality { get; set; }
        public DbSet<Auditorium> Auditorium { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Auditorium)
                .WithMany()
                .HasForeignKey(e => e.IdAuditorium);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Post)
                .WithMany()
                .HasForeignKey(e => e.IdPost);

            modelBuilder.Entity<Group>()
                .HasOne(g => g.ClassTeacher)
                .WithMany()
                .HasForeignKey(g => g.IdClassTeacher);

            modelBuilder.Entity<Group>()
                .HasOne(g => g.SpecialityFormOfStudy)
                .WithMany()
                .HasForeignKey(g => g.IdSpecialityFormOfStudy);

            modelBuilder.Entity<SpecialityFormOfStudy>()
                .HasOne(sfs => sfs.Speciality)
                .WithMany()
                .HasForeignKey(sfs => sfs.IdSpeciality);

            modelBuilder.Entity<SubjectSpecialityFormOfStudy>()
                .HasOne(ssfs => ssfs.Subject)
                .WithMany()
                .HasForeignKey(ssfs => ssfs.IdSubject);

            modelBuilder.Entity<SubjectSpecialityFormOfStudy>()
                .HasOne(ssfs => ssfs.SpecialityFormOfStudy)
                .WithMany()
                .HasForeignKey(ssfs => ssfs.IdSpecialityFormOfStudy);

            modelBuilder.Entity<TeacherSubject>()
                .HasOne(ts => ts.Teacher)
                .WithMany()
                .HasForeignKey(ts => ts.IdTeacher);

            modelBuilder.Entity<TeacherSubject>()
                .HasOne(ts => ts.SubjectSpeciality)
                .WithMany()
                .HasForeignKey(ts => ts.IdSubjectSpecialityFormOfStudy);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = HOMIE; Initial Catalog = MaybeMyTable; Trusted_Connection = True; Encrypt = False;");
        }
    }
}
