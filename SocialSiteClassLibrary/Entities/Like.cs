using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSiteClassLibrary.Entities
{
    public class Like : CancellableEntity
    {
        public Guid? UserId { get; set; }
        public Guid? PostId { get; set; }
        public Guid? CommentId { get; set; }
        
        public DateTime CreatedDate { get; set; }
    }
}
