using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialSiteClassLibrary.Entities;

namespace Infrastructure.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserId)
                .HasMaxLength(40)
                .IsRequired();
            
            builder.Property(x => x.PostId)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(x => x.CreatedDate).HasDefaultValue(new DateTime()).IsRequired();
            builder.Property(x => x.Text).HasMaxLength(1000).IsRequired();
        }
    }
}
