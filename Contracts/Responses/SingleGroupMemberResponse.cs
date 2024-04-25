using SocialSiteClassLibrary.Enums;

namespace Contracts.Responses
{
    public class SingleGroupMemberResponse
    {
        public Guid Id { get; set; }
        public bool Banned { get; set; }
        public DateTime? BannedDate { get; set; }
        public Guid? BannerId { get; set; }
        public BanReason? BanReason { get; set; }

        public Guid UserId { get; set; }
        //public User User { get; set; }
        public Guid GroupId { get; set; }
        //public Group Group { get; set; }
        public DateTime JoinDate { get; set; }
    }
}
