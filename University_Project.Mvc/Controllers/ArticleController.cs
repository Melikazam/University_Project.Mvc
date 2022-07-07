using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using University_Project.Mvc.Models;
using University_Project.Mvc.Services;

namespace University_Project.Mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("Create")]
        public ActionResult CreateArticle(Article article)
        {
            _articleService.CreateArticle(article);
            return Ok("Contact created");
        }

        [HttpGet("Get")]
        public ActionResult<List<Article>> GetArticles()
        {
            if (_articleService.GetArticles() == null) return NotFound("Article not found.");
            else return _articleService.GetArticles();
        }

        [HttpGet("Get/{id}")]
        public ActionResult<Article> GetArticle(int id)
        {
            if (_articleService.GetArticleById(id) == null) return NotFound("Product not found.");
            else return _articleService.GetArticleById(id);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteArticle(int id)
        {
            _articleService.DeleteArticleById(id);
            return Ok("Contact deleted");
        }

        [HttpPatch("Update/{id}")]
        public IActionResult UpdateArticle(Article article, int id)
        {
            _articleService.UpdateArticleById(article, id);
            return Ok("Prodcut updated");
        }
    }
}
