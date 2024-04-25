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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Banned)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(x => x.BannedDate);

            builder.Property(x => x.BanReason);

            builder.HasOne(x => x.Banner)
                .WithMany(u => (IEnumerable<User>)u.BannedEntities)
                .HasForeignKey(x => x.BannerId)
                .OnDelete(DeleteBehavior.NoAction);
            

            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(x => x.Surname)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Nickname)
                .HasMaxLength(50);

            //builder.Property(x => x.CreatedDate).HasDefaultValue(new DateTime()).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(20).IsRequired();
            /*
            builder.HasOne(x => x.Friend)
                .WithMany(f => f.Users)
                .HasForeignKey(x => x.FriendId)
                .OnDelete(DeleteBehavior.NoAction)*/
                
        }
    }
}
