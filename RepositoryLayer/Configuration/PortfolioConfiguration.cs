using EntityLayer.WevApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration;

public class PortfolioConfiguration: IEntityTypeConfiguration<Portfolio>
{
    public void Configure(EntityTypeBuilder<Portfolio> builder)
    {
        builder.Property(x => x.CreateDate).IsRequired().HasMaxLength(10);
        builder.Property(x => x.UpdateDate).IsRequired().HasMaxLength(10);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Title).IsRequired().HasMaxLength(10);
        builder.Property(x => x.FileName).IsRequired();
        builder.Property(x => x.FileType).IsRequired();
    }
}
