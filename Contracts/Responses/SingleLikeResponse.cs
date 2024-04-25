namespace Contracts.Responses
{
    public class SingleLikeResponse
    {
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public Guid? PostId { get; set; }
        public Guid? CommentId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
