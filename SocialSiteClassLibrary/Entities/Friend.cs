using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSiteClassLibrary.Entities
{
    public class Friends : BaseEntity
    {
        public int UserId { get; set; }
        public int FriendId { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
