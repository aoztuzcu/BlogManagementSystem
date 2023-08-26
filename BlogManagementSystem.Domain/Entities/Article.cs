using BlogManagementSystem.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogManagementSystem.Domain.Entities
{
    public class Article : FullAuditEntity<Guid>
    {
        public Article()
        {
            Comments = new HashSet<Comment>();
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public DateTime PublishDate { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public string CoverImage { get; set; } //4b091592-0062-4e04-b0f5-13ec27dfa6d9.jpg
      
        //Navigation properties
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
