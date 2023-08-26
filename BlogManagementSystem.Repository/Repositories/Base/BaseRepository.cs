using BlogManagementSystem.Domain.Entities.Base;
using BlogManagementSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BlogManagementSystem.Repository.Repositories.Base
{
    public class BaseRepository<TEntity, TKey> where TEntity : Entity<TKey>
    {
        protected readonly BlogManagementContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository()
        {
            _context = new BlogManagementContext();
            _dbSet = _context.Set<TEntity>();
        }

        public virtual TEntity Insert(TEntity entity)
        {
            //_ = Discard variable
            _ = _dbSet.Add(entity);
            _ = _context.SaveChanges();
            return entity;
        }

        public virtual void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _ = _context.SaveChanges();
        }

        public virtual void Delete(TKey id)
        {
            TEntity? entity = _dbSet.Find(id);
            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
            _ = _dbSet.Remove(entity);
            _ = _context.SaveChanges();
        }

        public virtual List<TEntity> GetAll()
        {
            List<TEntity> list = _dbSet.ToList();
            return list;
        }

        public virtual TEntity GetById(TKey id)
        {
            TEntity result = _dbSet.Find(id);
            return result;
        }

        public virtual List<TEntity> Where(Func<TEntity, bool> filter)
        {
            List<TEntity> list = _dbSet.Where(filter).ToList();
            return list;
        }
    }
}
