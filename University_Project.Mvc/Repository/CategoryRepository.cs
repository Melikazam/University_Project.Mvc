using System.Collections.Generic;
using System.Linq;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly  AppDbContext _context;
        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public void CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategoryById(int id)
        {
            _context.CartItems.Remove(_context.CartItems.FirstOrDefault(u => u.Id == id));
            _context.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.Select(u => u).ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}
