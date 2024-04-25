using SocialSiteClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class CreateLikeRequest
    {
        public bool Banned { get; set; }
        public DateTime? BannedDate { get; set; }
        public Guid? BannerId { get; set; }
        public BanReason? BanReason { get; set; }
        public Guid? UserId { get; set; }
        public Guid? PostId { get; set; }
        public Guid? CommentId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
