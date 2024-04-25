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

            builder.Property(x => x.Banned)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(x => x.BannedDate);

            builder.Property(x => x.BanReason);

            builder.Property(x => x.BannerId);


            builder.Property(x => (x).IsCancelled)
                .IsRequired();

            builder.Property(x => x.AddedDate).HasDefaultValue(new DateTime()).IsRequired();
        }
    }
}
