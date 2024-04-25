using SocialSiteClassLibrary.Entities;
using SocialSiteClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class CreateGroupMemberRequest
    {
        public bool Banned { get; set; }
        public DateTime? BannedDate { get; set; }
        public Guid? BannerId { get; set; }
        public BanReason? BanReason { get; set; }

        public Guid UserId { get; set; }
        //public User User { get; set; }
        public Guid GroupId { get; set; }
        //public Group Group { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
