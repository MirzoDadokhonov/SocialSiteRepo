using SocialSiteClassLibrary.Enums;

namespace Contracts.Responses
{
    public class SingleMessageResponse
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public string Text { get; set; }
        public DateTime SentDate { get; set; }
        public bool Banned { get; set; }
        public DateTime? BannedDate { get; set; }
        public Guid? BannerId { get; set; }
        public BanReason? BanReason { get; set; }
        public bool IsCancelled { get; set; }
    }
}
