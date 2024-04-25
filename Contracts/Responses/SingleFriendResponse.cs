using SocialSiteClassLibrary.Enums;

namespace Contracts.Responses
{
    public class SingleFriendResponse
    {
        public Guid Id { get; set; }
        public bool Banned { get; set; }
        public DateTime? BannedDate { get; set; }
        public Guid? BannerId { get; set; }
        public BanReason? BanReason { get; set; }
        public Guid UserId { get; set; }
        public Guid FriendId { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
