using BlogManagementSystem.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogManagementSystem.Domain.Entities
{
    public class Comment : FullAuditEntity<Guid>
    {
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        [ForeignKey("Article")]
        public Guid ArticleId { get; set; }
        public string? Content { get; set; }

        //Navigation properties
        public virtual User User { get; set; }
        public virtual Article Article { get; set; }
    }
}
