using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSiteClassLibrary.Entities
{
    public class Like : CancellableEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
        public Guid CommentId { get; set; }
        public Comment Comment { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
