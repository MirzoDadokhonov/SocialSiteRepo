using SocialSiteClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class DeleteFriendRequest
    {
        public bool Banned { get; set; }
        public DateTime? BannedDate { get; set; }
        public Guid? BannerId { get; set; }
        public BanReason? BanReason { get; set; }
        public Guid UserId { get; set; }
        public Guid FriendId { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
