
namespace SocialSiteClassLibrary.Entities
{
    public class Comment : CancellableEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<Like> Likes { get; set; }
    }
}
