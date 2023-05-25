using WpfApp.Models.ReferenceBooksModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WpfApp.Configuration.ReferenceBooksConfiguration
{
    internal class TypeOfControlConfiguration : IEntityTypeConfiguration<TypeOfControl>
    {
        public void Configure(EntityTypeBuilder<TypeOfControl> builder)
        {
            builder.ToTable("TypeOfControl").HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);

            builder.HasData(new TypeOfControl[]
            {
                new TypeOfControl {Id = 1, Name="Ответ на занятии"},
                new TypeOfControl {Id = 2, Name="Практическая работа"},
                new TypeOfControl {Id = 3, Name="Лабораторная работа"},
                new TypeOfControl {Id = 4, Name="Промежуточный ежемесячный(аттестация)"},
                new TypeOfControl {Id = 5, Name="Дифференцированный зачёт"},
                new TypeOfControl {Id = 6, Name="Зачёт за семестр"},
                new TypeOfControl {Id = 7, Name="Квалификационный экзамен"},
                new TypeOfControl {Id = 8, Name="Курсовой проект"},
                new TypeOfControl {Id = 9, Name="Курсовая работа"},
                new TypeOfControl {Id = 10, Name="Практика"},
                new TypeOfControl {Id = 11, Name="Самостоятельная работа"},
                new TypeOfControl {Id = 12, Name="Контрольная работа"},
                new TypeOfControl {Id = 13, Name="ГИА"},
                new TypeOfControl {Id = 14, Name="Демоэкзамен"}
            });
        }

    }
}
