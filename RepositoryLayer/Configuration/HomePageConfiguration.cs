using EntityLayer.WevApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration;

public class HomePageConfiguration: IEntityTypeConfiguration<HomePage>
{
    public void Configure(EntityTypeBuilder<HomePage> builder)
    {
        builder.Property(x => x.CreateDate).IsRequired().HasMaxLength(10);
        builder.Property(x => x.UpdateDate).IsRequired().HasMaxLength(10);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Header).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(2000);
        builder.Property(x => x.VideoLink).IsRequired();
    }
}