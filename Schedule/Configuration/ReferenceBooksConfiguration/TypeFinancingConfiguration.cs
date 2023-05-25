using WpfApp.Models.ReferenceBooksModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WpfApp.Configuration.ReferenceBooksConfiguration
{
    internal class TypeFinancingConfiguration : IEntityTypeConfiguration<TypeFinancing>
    {
        public void Configure(EntityTypeBuilder<TypeFinancing> builder)
        {
            builder.ToTable("TypeFinancing").HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);

            builder.HasData(new TypeFinancing[]
            {
                new TypeFinancing { Id=1, Name="Бюджетное финансирование"},
                new TypeFinancing { Id=2, Name="Коммерческое финансирование"}
            });

        }
    }
}
