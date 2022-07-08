using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Services
{
    public interface ICategoryService
    {
        void CreateCategory(Category category);
        List<Category> GetCategories();
        Category GetCategoryById(int id);
        void DeleteCategoryById(int id);
    }
}
