using WpfApp.Models.ReferenceBooksModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WpfApp.Configuration.ReferenceBooksConfiguration
{
    internal class StatusGroupConfiguration : IEntityTypeConfiguration<StatusGroup>
    {
        public void Configure(EntityTypeBuilder<StatusGroup> builder)
        {
            builder.ToTable("StatusGroup").HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);

            builder.HasData(new StatusGroup[]
            {
                new StatusGroup {Id=1, Name="Учится"},
                new StatusGroup {Id=2, Name="Выпущена"},
                new StatusGroup {Id=3, Name="Расформирована"},
            });

        }

    }
}
