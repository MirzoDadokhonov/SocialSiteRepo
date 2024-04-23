using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSiteClassLibrary.Entities
{
    public class Post : CancellableEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }

    }
}
