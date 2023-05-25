using WpfApp.Models.GeneralModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WpfApp.Configuration.GeneralModuleConfiguration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(p => p.Id);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Patronymic).HasMaxLength(30);
            builder.Property(x => x.Active).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.DateOfBirth).IsRequired().HasColumnType("date");
            builder.Property(x => x.DateStartContract).IsRequired().HasColumnType("date").HasDefaultValue(DateTime.MinValue);
            builder.Property(x => x.DateEndContract).IsRequired().HasColumnType("date");
            builder.Property(x => x.LastQualification).IsRequired().HasColumnType("date").HasDefaultValue(DateTime.MinValue);
            builder.Property(x => x.IdPost).IsRequired();
            builder.Property(x => x.IdGender).IsRequired();

            builder
                .HasOne(p => p.Post)
                .WithMany()
                .HasForeignKey(p => p.IdPost)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(p => p.Gender)
                .WithMany()
                .HasForeignKey(p => p.IdGender)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new Employee[]
            {
                new Employee{ Id=1, FirstName="Политехнический",LastName="колледж", Patronymic="БГТУ",DateOfBirth=DateTime.Parse("01.01.1884"),DateStartContract=DateTime.Parse("01.01.1884"),
                    DateEndContract=DateTime.MaxValue,LastQualification=DateTime.Parse("01.01.1884"), IdPost=1,IdGender=1, Active=true},
                new Employee{ Id=2, FirstName="Балашова",LastName="Татьяна", Patronymic="Евгеньевна",DateOfBirth=DateTime.Parse("1967-04-14"),DateStartContract=DateTime.Parse("2004-10-25"),
                    DateEndContract=DateTime.MaxValue,LastQualification=DateTime.Parse("2021-10-25"), IdPost=1,IdGender=2, Active=true},
                new Employee{ Id=3, LastName="Алхименкова",FirstName="Анна", Patronymic="Анатольевна",DateOfBirth=DateTime.Parse("1978-02-10"),
                    DateStartContract=DateTime.Parse("2002-01-24"),DateEndContract=DateTime.MaxValue,LastQualification=DateTime.Parse("2021-10-25"), IdPost=1,IdGender=2, Active=true},
                new Employee{ Id=4, LastName="Антропов",FirstName="Петр", Patronymic="Павлович",DateOfBirth=DateTime.Parse("1961-06-18"),
                    DateStartContract=DateTime.Parse("1982-08-01"),DateEndContract=DateTime.MaxValue,LastQualification=DateTime.Parse("2021-10-25"), IdPost=1,IdGender=2, Active=true}
            }) ;
        }
    }
}
