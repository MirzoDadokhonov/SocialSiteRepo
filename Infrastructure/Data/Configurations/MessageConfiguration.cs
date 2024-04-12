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

            builder.Property(x => x.SenderId)
                .HasMaxLength(40)
                .IsRequired();
            
            builder.Property(x => x.ReceiverId)
                .HasMaxLength(40)
                .IsRequired();
            
            builder.Property(x => x.Text).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.SentDate).HasDefaultValue(new DateTime()).IsRequired();
            
        }
    }
}
