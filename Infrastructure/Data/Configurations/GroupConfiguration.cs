using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialSiteClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {/*
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Banned)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(x => x.BannedDate)
                .IsRequired();

            builder.Property(x => x.BanReason)
                .IsRequired();

            builder.HasOne(x => x.Banner)
                .WithMany(u => (IEnumerable<Group>)u.BannedEntities)
                .HasForeignKey(x => x.BannerId)
                .OnDelete(DeleteBehavior.Restrict);
            */

            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(x => x.Description)
                .HasMaxLength(1000);

            builder.HasOne(x => x.Creator)
                .WithMany(x => x.Groups)
                .HasForeignKey(x => x.CreatorId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

        }
    }
}
