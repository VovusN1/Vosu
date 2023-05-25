using WpfApp.Models.ContingentModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WpfApp.Configuration.ContingentModuleConfiguration
{
    internal class SubjectSpecialityFormOfStudyConfiguration : IEntityTypeConfiguration<SubjectSpecialityFormOfStudy>
    {
        public void Configure(EntityTypeBuilder<SubjectSpecialityFormOfStudy> builder)
        {
            builder.ToTable("SubjectSpecialityFormOfStudy").HasKey(p => p.Id);
            builder.Property(p => p.IdSubject).IsRequired();
            builder.Property(p => p.IdSpecialityFormOfStudy).IsRequired();
            builder.Property(p => p.IdTypeOfControl).IsRequired();
            builder.Property(p => p.NumberSemestr).IsRequired();
            builder.Property(p => p.IdAcademicYear).IsRequired();
            builder.Property(p => p.NumberCourse).IsRequired();
            builder.Property(p => p.MaxHours).IsRequired();
            builder.Property(p => p.ObligatoryHours).IsRequired();
            builder.Property(p => p.LecturesHours).IsRequired();
            builder.Property(p => p.PracticalsHours).IsRequired();
            builder.Property(p => p.TotalHours).IsRequired();
            builder.Property(p => p.ConsultationsHours).IsRequired();
            builder.Property(p => p.LaboratoryHours).IsRequired();
            builder.Property(p => p.IdTypeOfControl).IsRequired();
            builder.Property(p => p.YearApprovals).IsRequired();
            builder
                .HasOne(p => p.Subject)
                .WithMany()
                .HasForeignKey(p => p.IdSubject)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.SpecialityFormOfStudy)
                .WithMany()
                .HasForeignKey(p => p.IdSpecialityFormOfStudy)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.AcademicYear)
                .WithMany()
                .HasForeignKey(p => p.IdAcademicYear)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(p => p.TypeOfControl)
                .WithMany()
                .HasForeignKey(p => p.IdTypeOfControl)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
