using WpfApp.Models.ReferenceBooksModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WpfApp.Configuration.ReferenceBooksConfiguration
{
    internal class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post").HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(60);

            builder.HasData(new Post[]
            {
                new Post { Id=1, Name="Директор"},
                new Post { Id=2, Name="Заместитель директора по учебно-методической работе"},
                new Post { Id=3, Name="Заместитель директора по воспитательной работе"},
                new Post { Id=4, Name="Секретарь руководителя(Директора)"},
                new Post { Id=5, Name="Заведующий очным отделением"},
                new Post { Id=6, Name="Заведующий заочным отделением"},
                new Post { Id=7, Name="Методист"},
                new Post { Id=8, Name="Секретарь учебной части"},
                new Post { Id=9, Name="Техник-программист"},
                new Post { Id=10, Name="Преподаватель"}
            });
        }
    }
}
