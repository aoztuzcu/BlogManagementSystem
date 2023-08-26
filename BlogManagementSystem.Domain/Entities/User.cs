using BlogManagementSystem.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogManagementSystem.Domain.Entities
{
    public class User : FullAuditEntity<Guid>
    {
        public User()
        {
            Articles = new HashSet<Article>();
            Comments = new HashSet<Comment>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        [NotMapped]
        public string FullName => $"{Name} {Surname}";
        public string Email { get; set; }
        public string Password { get; set; }

        //Navigation properties
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }
    }
}
