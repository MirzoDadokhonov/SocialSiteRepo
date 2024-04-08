using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSiteClassLibrary.Entities
{
    public class Like : BaseEntity
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int CommentId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
