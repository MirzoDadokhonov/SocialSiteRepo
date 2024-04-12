using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSiteClassLibrary.Entities
{
    public class CancellableEntity : BaseEntity
    {
        public bool IsCancelled { get; set; }
    }
}
