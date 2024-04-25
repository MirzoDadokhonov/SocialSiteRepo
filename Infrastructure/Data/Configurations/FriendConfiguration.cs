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

            builder.Property(x => x.BannedDate)
                .IsRequired();

            builder.Property(x => x.BanReason)
                .IsRequired();

            builder.HasOne(x => x.Banner)
                .WithMany(u => (IEnumerable<Friend>)u.BannedEntities)
                .HasForeignKey(x => x.BannerId)
                .OnDelete(DeleteBehavior.NoAction);
            

            builder.Property(x => (x).IsCancelled)
                .IsRequired();

            builder.Property(x => x.AddedDate).HasDefaultValue(new DateTime()).IsRequired();
        }
    }
}
