using BlogManagementSystem.Domain.Entities.Audits;
using System.ComponentModel.DataAnnotations;

namespace BlogManagementSystem.Domain.Entities.Base
{
    public abstract class Entity
    {

    }

    public class Entity<TKey> : Entity
    {
        [Key]
        public TKey Id { get; set; }
    }

    public class FullAuditEntity<TKey> : Entity<TKey>,IMayHaveCreationTime,IMayHaveCreatorUser
    {
        //Audit Properties
        public DateTime CreationTime { get; set; }
        public Guid CreatorUserId { get; set; }
        public Guid? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Guid? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
