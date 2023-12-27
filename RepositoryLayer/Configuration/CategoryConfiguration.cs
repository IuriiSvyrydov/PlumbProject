using EntityLayer.WevApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x => x.CreateDate).IsRequired().HasMaxLength(10);
        builder.Property(x => x.UpdateDate).IsRequired().HasMaxLength(10);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
    }

}