using WpfApp.Models.ReferenceBooksModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WpfApp.Configuration.ReferenceBooksConfiguration
{
    internal class FormOfStudyConfiguration : IEntityTypeConfiguration<FormOfStudy>
    {
        public void Configure(EntityTypeBuilder<FormOfStudy> builder)
        {
            builder.ToTable("FormOfStudy").HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);

            builder.HasData(new FormOfStudy[]
            {
                new FormOfStudy {Id=1, Name="Очная форма обучения"},
                new FormOfStudy {Id=2, Name="Заочная форма обучения"}
            });
        }
    }
}
