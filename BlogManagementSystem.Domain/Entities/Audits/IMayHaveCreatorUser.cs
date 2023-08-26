namespace BlogManagementSystem.Domain.Entities.Audits
{
    public interface IMayHaveCreatorUser
    {
        public Guid CreatorUserId { get; set; }
    }
}
