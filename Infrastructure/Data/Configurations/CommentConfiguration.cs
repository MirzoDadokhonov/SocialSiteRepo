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

            builder.Property(x => x.Banned)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(x => x.BannedDate);

            builder.Property(x => x.BanReason);

            builder.Property(x => x.BannerId);

            builder.Property(x => (x).IsCancelled)
                .IsRequired();


            builder.HasOne(u => u.User)
                .WithMany(c => c.Comments)
                .HasForeignKey(u1 => u1.UserId)
                .OnDelete(DeleteBehavior.NoAction)
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
