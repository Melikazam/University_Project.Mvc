using System.Collections.Generic;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Repository
{
    public interface ICategoryRepository
    {
        void CreateCategory(Category category);
        void DeleteCategoryById(int id);
        List<Category> GetCategories();
        Category GetCategoryById(int id);
    }
}