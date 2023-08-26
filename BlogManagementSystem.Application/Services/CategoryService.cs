using BlogManagementSystem.Application.Contracts.Interfaces;
using BlogManagementSystem.Domain.Entities;
using BlogManagementSystem.Repository.Repositories;

namespace BlogManagementSystem.Application.Services
{
    public class CategoryService : ICategoryService
    {
        public readonly CategoryRepository _categoryRepository;
        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }
        public Category Get(Guid id)
        {
            var category = _categoryRepository.Where(x => x.Id == id).FirstOrDefault();
            return category;
        }
    }

    public class CategoryNewService : ICategoryService
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoryNewService()
        {
            _categoryRepository = new CategoryRepository();
        }
        public Category Get(Guid id)
        {
            var category = _categoryRepository.Where(x => x.Id == id && !x.IsDeleted).FirstOrDefault();
            return category;
        }
    }
}
