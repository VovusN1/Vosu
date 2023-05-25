using WpfApp.Models.ReferenceBooksModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WpfApp.Configuration.ReferenceBooksConfiguration
{
    internal class DepartamentConfiguration : IEntityTypeConfiguration<Departament>
    {
        public void Configure(EntityTypeBuilder<Departament> builder)
        {
            builder.ToTable("Departament").HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);

            builder.HasData(new Departament[]
            {
                new Departament {Id=1, Name="Дневное отделение"},
                new Departament {Id=2, Name="Заочное отделение"}
            });
        }
    }
}
