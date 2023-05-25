using WpfApp.Models.ContingentModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WpfApp.Configuration.ContingentModuleConfiguration
{
    public class SpecialityFormOfStudyConfiguration : IEntityTypeConfiguration<SpecialityFormOfStudy>
    {
        public void Configure(EntityTypeBuilder<SpecialityFormOfStudy> builder)
        {
            builder.ToTable("SpecialityFormOfStudy").HasKey(p => p.Id);
            builder.Property(p => p.IdSpeciality).IsRequired();
            builder.Property(p => p.IdDepartament).IsRequired();
            builder.Property(p => p.IdFormOfStudy).IsRequired();

            builder
                .HasOne(p => p.Speciality)
                .WithMany()
                .HasForeignKey(p => p.IdSpeciality)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.Departament)
                .WithMany()
                .HasForeignKey(p => p.IdDepartament)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.FormOfStudy)
                .WithMany()
                .HasForeignKey(p => p.IdFormOfStudy)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new SpecialityFormOfStudy[]
            {
                new SpecialityFormOfStudy(){ Id = 1, IdSpeciality=1, IdFormOfStudy=1, IdDepartament=1},
                new SpecialityFormOfStudy(){ Id = 2, IdSpeciality=2, IdFormOfStudy=1, IdDepartament=1},
                new SpecialityFormOfStudy(){ Id = 3, IdSpeciality=3, IdFormOfStudy=1, IdDepartament=1},
                new SpecialityFormOfStudy(){ Id = 4, IdSpeciality=4, IdFormOfStudy=1, IdDepartament=1},
                new SpecialityFormOfStudy(){ Id = 5, IdSpeciality=5, IdFormOfStudy=1, IdDepartament=1},
                new SpecialityFormOfStudy(){ Id = 6, IdSpeciality=5, IdFormOfStudy=2, IdDepartament=2},
                new SpecialityFormOfStudy(){ Id = 7, IdSpeciality=6, IdFormOfStudy=1, IdDepartament=1},
                new SpecialityFormOfStudy(){ Id = 8, IdSpeciality=6, IdFormOfStudy=2, IdDepartament=2},
            });
        }

    }
}
