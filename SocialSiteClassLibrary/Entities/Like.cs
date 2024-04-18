using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSiteClassLibrary.Entities
{
    public class Like : CancellableEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
