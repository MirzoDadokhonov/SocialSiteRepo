using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSiteClassLibrary.Entities
{
    public class GroupMember
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
