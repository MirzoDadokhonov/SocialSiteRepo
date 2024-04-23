namespace Contracts.Responses
{
    public class SingleGroupMemberResponse
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
