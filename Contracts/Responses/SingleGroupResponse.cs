namespace Contracts.Responses
{
    public class SingleGroupResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CreatorId { get; set; }
    }
}
