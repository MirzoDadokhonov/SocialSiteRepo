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
    public class GruoupMemberConfiguration : IEntityTypeConfiguration<GroupMember>
    {
        public void Configure(EntityTypeBuilder<GroupMember> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Banned)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(x => x.BannedDate);

            builder.Property(x => x.BanReason);

            builder.HasOne(x => x.Banner)
                .WithMany(u => (IEnumerable<GroupMember>)u.BannedEntities)
                .HasForeignKey(x => x.BannerId)
                .OnDelete(DeleteBehavior.NoAction);
            

            builder.HasOne(x => x.User)
                .WithMany(u => u.GroupMembers)
                .HasForeignKey(x => x.Id)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();
            
            builder.HasOne(x => x.Group)
                .WithMany(g => g.GroupMembers)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.Property(x => x.JoinDate).HasDefaultValue(new DateTime()).IsRequired();
        }
    }
}
