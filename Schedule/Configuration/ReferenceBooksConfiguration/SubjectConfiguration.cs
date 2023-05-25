using WpfApp.Models.ReferenceBooksModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WpfApp.Configuration.ReferenceBooksConfiguration
{
    internal class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Subject").HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Index).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            //builder.Property(p => p.MaxHours).IsRequired();
            //builder.Property(p => p.LectureHours).IsRequired();
            //builder.Property(p => p.PracticalHours).IsRequired();
            //builder.Property(p => p.TotalHours).IsRequired();
            builder.HasData(new Subject[]
            {
                new Subject { Id=1, Name="Прикладное программирование",Index="OO.01"},
                new Subject { Id=2, Name="База данных",Index="OO.02"}
            });
        }
    }
}
