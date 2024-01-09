using EntityLayer.WevApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration;

public class TestimonialConfiguration: IEntityTypeConfiguration<Testimonial>
{
    public void Configure(EntityTypeBuilder<Testimonial> builder)
    {
        builder.Property(x => x.CreateDate).IsRequired().HasMaxLength(10);
        builder.Property(x => x.UpdateDate).HasMaxLength(10);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Comment).IsRequired().HasMaxLength(2000);
        builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
        builder.Property(x => x.FileName).IsRequired();
        builder.Property(x => x.FileType).IsRequired();
        builder.HasData(new Testimonial
        {
            Id = 1,
            Comment = "test Comment",
            Title = "test",
            FullName = "ferro5",
            FileName = "test",
            FileType = "test",
        });
    }
}