using BlogManagementSystem.Domain.Entities.Audits;
using BlogManagementSystem.Domain.Entities.Base;

namespace BlogManagementSystem.Domain.Entities
{
    public class UserLoginLog : Entity<Guid>, IMayHaveCreationTime
    {
        public Guid UserId { get; set; }
        public string IPAddress { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreationTime { get; set; } 
    }
}
