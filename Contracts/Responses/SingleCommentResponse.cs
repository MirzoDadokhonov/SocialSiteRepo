namespace Contracts.Responses
{
    public class SingleCommentResponse
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
