using BlogManagementSystem.Domain.Entities.Base;

namespace BlogManagementSystem.Domain.Entities
{
    public class Category : FullAuditEntity<Guid>
    {
        public Category()
        {
            Articles = new HashSet<Article>();
        }
        public string Description { get; set; }

        //Navigation properties
        public virtual ICollection<Article> Articles { get; set; }
    }
}
