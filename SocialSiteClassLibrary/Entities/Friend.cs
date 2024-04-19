using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSiteClassLibrary.Entities
{
    public class Friend : CancellableEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public DateTime AddedDate { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
