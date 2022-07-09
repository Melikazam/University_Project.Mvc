using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using University_Project.Mvc.Models;
using University_Project.Mvc.Services;

namespace University_Project.Mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    { 
        private readonly ICategoryService _categoryService;
         public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("Create")]
        public ActionResult CreateCategory(Category category)
        {
            _categoryService.CreateCategory(category);
            return Ok("Contact created");
        }

        [HttpGet("Get")]
        public ActionResult<List<Category>> GetCategories()
        {
            return _categoryService.GetCategories();
        }

        [HttpGet("Get/{id}")]
        public ActionResult<Category> GetCategory(int id)
        {
            if (_categoryService.GetCategoryById(id) == null) return NotFound("Product not found.");
            else return _categoryService.GetCategoryById(id);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteCategoryById(int id)
        {
            _categoryService.DeleteCategoryById(id);
            return Ok("Contact deleted");
        }
    }
}
