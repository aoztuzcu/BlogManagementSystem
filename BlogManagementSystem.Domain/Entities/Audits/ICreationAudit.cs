namespace BlogManagementSystem.Domain.Entities.Audits
{
    public interface ICreationAudit : IMayHaveCreationTime, IMayHaveCreatorUser
    {
    }
}
