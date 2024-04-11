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

            builder.Property(x => x.UserId)
                .HasMaxLength(40)
                .IsRequired();
            
            builder.Property(x => x.GroupId)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(x => x.JoinDate).HasDefaultValue(new DateTime()).IsRequired();
        }
    }
}
