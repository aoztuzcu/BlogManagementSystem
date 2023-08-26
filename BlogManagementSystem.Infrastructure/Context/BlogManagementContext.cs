using BlogManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogManagementSystem.Infrastructure.Context
{
    public class BlogManagementContext : DbContext
    {
        //public BlogManagementContext(DbContextOptions<BlogManagementContext> options) : base(options)
        //{
        //}

        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<UserLoginLog> UserLoginLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Melih\SQLEXPRESS; Initial Catalog=BlogManagementSystem; Integrated Security=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
