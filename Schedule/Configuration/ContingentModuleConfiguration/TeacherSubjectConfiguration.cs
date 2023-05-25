using WpfApp.Models.ContingentModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Configuration.ContingentModuleConfiguration
{
    internal class TeacherSubjectConfiguration :IEntityTypeConfiguration<TeacherSubject>
    {
        public void Configure(EntityTypeBuilder<TeacherSubject> builder)
        {
            builder.ToTable("TeacherSubject").HasKey(p => p.Id);
            builder.Property(p => p.IdTeacher).IsRequired();
            builder.Property(p => p.IdSubjectSpecialityFormOfStudy).IsRequired(); 
            builder.Property(p => p.TotalHours).IsRequired();
            builder.Property(p => p.LecturesHours).IsRequired();
            builder.Property(p => p.PracticalsHours).IsRequired();
            builder.Property(p => p.LaboratoryHours).IsRequired();
            builder.Property(p => p.ConsultationsHours).IsRequired();

            builder
                .HasOne(p => p.Teacher)
                .WithMany()
                .HasForeignKey(p => p.IdTeacher)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.SubjectSpeciality)
                .WithMany()
                .HasForeignKey(p => p.IdSubjectSpecialityFormOfStudy)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
