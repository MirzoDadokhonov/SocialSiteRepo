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
    public class FriendConfiguration : IEntityTypeConfiguration<Friend>
    {
        public void Configure(EntityTypeBuilder<Friend> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserId)
                .HasMaxLength(40)
                .IsRequired();
            
            builder.Property(x => x.FriendId)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(x => x.AddedDate).HasDefaultValue(new DateTime()).IsRequired();
        }
    }
}
