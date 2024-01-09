using EntityLayer.WevApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration;

public class AboutConfiguration : IEntityTypeConfiguration<About>
{
    public void Configure(EntityTypeBuilder<About> builder)
    {
        builder.Property(x => x.CreateDate).IsRequired().HasMaxLength(10);
        builder.Property(x => x.UpdateDate).HasMaxLength(10);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Description).IsRequired()
            .HasMaxLength(500);
        builder.Property(x => x.Header).IsRequired()
            .HasMaxLength(200);
        builder.Property(x => x.Clients).IsRequired()
            .HasMaxLength(200);
        builder.Property(x => x.Projects).IsRequired()
            .HasMaxLength(5);
        builder.Property(x => x.HoursOfSupport).IsRequired()
            .HasMaxLength(5);
        builder.Property(x => x.HardWorkers).IsRequired()
            .HasMaxLength(5);
        builder.HasData(new About
        {
            Id = 1,
            Header = "Lorem isoum dolor sit amet",
            Description = " is simply dummy text of the printing and typesetting industry." +
                          " Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                          " when an unknown printer took a galley of type and scrambled it to make a type specimen book. " +
                          "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
            Clients = 5,
            Projects = 5,
            HoursOfSupport = 150,
            HardWorkers = 3,
            FileName = "test",
            FileType = "test",
            SocialMediaId = 1,
           
        });

    }
}