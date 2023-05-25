using WpfApp.Models.ReferenceBooksModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WpfApp.Configuration.ReferenceBooksConfiguration
{
    internal class SpecialityConfiguration : IEntityTypeConfiguration<Speciality>
    {
        public void Configure(EntityTypeBuilder<Speciality> builder)
        {
            builder.ToTable("Speciality").HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Number).IsRequired().HasMaxLength(20);

            builder.HasData(new Speciality[]
            {
                new Speciality {Id=1, Number="09.02.03", Name="Программирование в компьютерных системах"},
                new Speciality {Id=2, Number="09.02.07", Name="Информационные системы и программирование"},
                new Speciality {Id=3, Number="15.02.12",  Name="Монтаж, техническое обслуживание и ремонт промышленного оборудования (по отраслям)"},
                new Speciality {Id=4, Number="15.02.14", Name="Оснащение средствами автоматизации технологических процессов и производств (по отраслям)"},
                new Speciality {Id=5, Number="15.02.08",  Name="Технология машиностроения"},
                new Speciality {Id=6, Number="38.02.01", Name="Экономика и бухгалтерский учет (по отраслям)"}
            });

        }
    }
}
