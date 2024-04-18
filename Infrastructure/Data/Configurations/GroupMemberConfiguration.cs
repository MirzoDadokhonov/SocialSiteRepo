﻿using Microsoft.EntityFrameworkCore;
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
    public class GruoupMemberConfiguration : IEntityTypeConfiguration<GroupMember>
    {
        public void Configure(EntityTypeBuilder<GroupMember> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithMany(u => u.GroupMembers)
                .HasForeignKey(x => x.Id)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            
            builder.HasOne(x => x.Group)
                .WithMany(g => g.GroupMembers)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.Property(x => x.JoinDate).HasDefaultValue(new DateTime()).IsRequired();
        }
    }
}
