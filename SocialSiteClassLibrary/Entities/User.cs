﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SocialSiteClassLibrary.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public new string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Guid? FriendId { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<GroupMember> GroupMembers { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Friend> Friends { get; set; }
        public ICollection<Message> SentMessages { get; set; }
        public ICollection<Message> ReceivedMessages { get; set; }
        public ICollection<BaseEntity> BannedEntities { get; set; }
    }
}
