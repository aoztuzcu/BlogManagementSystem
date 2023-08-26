using BlogManagementSystem.Application.Contracts.Interfaces;
using BlogManagementSystem.Domain.Entities;

namespace BlogManagementSystem.Application.Services
{
    public class ArticleService
    {
        private readonly ICategoryService categoryService; // Coupling düşük
        public ArticleService()
        {
            categoryService = new CategoryNewService();
        }
        public Article Insert(Article article)
        {
            Category category = categoryService.Get(article.CategoryId);
            bool isExists = category != null;
            if (!isExists)
                throw new Exception("Category not found");
            return article;
        }
    }
}
