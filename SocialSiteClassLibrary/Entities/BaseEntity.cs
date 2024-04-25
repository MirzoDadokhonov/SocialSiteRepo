using SocialSiteClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSiteClassLibrary.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
        
        public Guid Id { get; }
        public bool Banned { get; set; }
        public DateTime? BannedDate { get; set; }
        public Guid? BannerId { get; set; }
        //public User? Banner { get; set; }
        public BanReason? BanReason { get; set; }
    }
}
