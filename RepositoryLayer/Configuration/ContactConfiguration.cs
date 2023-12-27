using EntityLayer.WevApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration;

public class ContactConfiguration: IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.Property(x => x.CreateDate).IsRequired().HasMaxLength(10);
        builder.Property(x => x.UpdateDate).IsRequired().HasMaxLength(10);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.Location).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Call).IsRequired().HasMaxLength(17);
        builder.Property(x => x.Map).IsRequired();
    }

}