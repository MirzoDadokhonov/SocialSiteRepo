namespace Contracts.Responses
{
    public class SingleLikeResponse
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
