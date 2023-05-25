using WpfApp.Models.ContingentModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WpfApp.Configuration.ContingentModuleConfiguration
{
    internal class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("Group").HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.IdClassTeacher).IsRequired();
            builder.Property(p => p.IdSpecialityFormOfStudy).IsRequired();

            builder
                .HasOne(p => p.ClassTeacher)
                .WithMany()
                .HasForeignKey(p => p.IdClassTeacher)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.SpecialityFormOfStudy)
                .WithMany()
                .HasForeignKey(p => p.IdSpecialityFormOfStudy)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.TypeFinancing)
                .WithMany()
                .HasForeignKey(p => p.IdTypeFinancing)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.StatusGroup)
                .WithMany()
                .HasForeignKey(p => p.IdStatusGroup)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
