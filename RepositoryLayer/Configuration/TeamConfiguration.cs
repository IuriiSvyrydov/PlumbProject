﻿using EntityLayer.WevApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration;

public class TeamConfiguration: IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.Property(x => x.CreateDate).IsRequired().HasMaxLength(10);
        builder.Property(x => x.UpdateDate).HasMaxLength(10);
        builder.Property(x => x.RowVersion).IsRowVersion();
        builder.Property(x => x.FileName).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
        builder.Property(x => x.FileName).IsRequired();
        builder.Property(x => x.FileType).IsRequired();
        builder.HasData(new Team
        {
            Id = 1,
            FullName = "ferro5",
            Title = "test",
            FaceBook = "testFacebook",
            Instagram = "testInstagram",
            FileName = "test",
            FileType = "test"
        });

    }
}