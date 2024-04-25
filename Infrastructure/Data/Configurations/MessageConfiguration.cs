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
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
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
                .WithMany(u => (IEnumerable<Message>)u.BannedEntities)
                .HasForeignKey(x => x.BannerId)
                .OnDelete(DeleteBehavior.NoAction);
            

            builder.Property(x => (x).IsCancelled)
                .IsRequired();


            builder.HasOne(x => x.Sender)
                .WithMany(u => u.SentMessages)
                .HasForeignKey(x => x.SenderId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();
            
            builder.HasOne(x => x.Receiver)
                .WithMany(u => u.ReceivedMessages)
                .HasForeignKey(x => x.ReceiverId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();
            
            builder.Property(x => x.Text).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.SentDate).HasDefaultValue(new DateTime()).IsRequired();
            
        }
    }
}
