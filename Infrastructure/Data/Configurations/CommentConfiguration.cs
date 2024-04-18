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

            builder.HasOne(u => u.User)
                .WithMany(c => c.Comments)
                .HasForeignKey(u1 => u1.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            
            builder.HasOne(x => x.Post)
                .WithMany(c => c.Comments)
                .HasForeignKey(x => x.PostId)
                .IsRequired();

            builder.Property(x => x.CreatedDate).HasDefaultValue(new DateTime()).IsRequired();
            builder.Property(x => x.Text).HasMaxLength(1000).IsRequired();
        }
    }
}
