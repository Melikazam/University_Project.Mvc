using System.Collections.Generic;
using University_Project.Mvc.Models;
using University_Project.Mvc.Repository;

namespace University_Project.Mvc.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void CreateCategory(Category category)
        {
            _categoryRepository.CreateCategory(category);
        }

        public void DeleteCategoryById(int id)
        {
            _categoryRepository.DeleteCategoryById(id);
        }

        public List<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetCategoryById(id);
        }
    }
}
