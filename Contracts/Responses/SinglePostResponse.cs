namespace Contracts.Responses
{
    public class SinglePostResponse
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
