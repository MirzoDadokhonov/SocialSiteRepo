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
    public class LikeConfiguration : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserId)
                .HasMaxLength(40)
                .IsRequired();
            
            builder.Property(x => x.PostId)
                .HasMaxLength(40)
                .IsRequired();
            
            builder.Property(x => x.CommentId)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(x => x.CreatedDate).HasDefaultValue(new DateTime()).IsRequired();
        }
    }
}
