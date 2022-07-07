using System.Collections.Generic;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleService _articleService; 

        ArticleService(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public void CreateArticle(Article article)
        {
             _articleService.CreateArticle(article);
        }

        public void DeleteArticleById(int id)
        {
            _articleService.DeleteArticleById(id);
        }

        public Article GetArticleById(int id)
        {
            return _articleService.GetArticleById(id);

        }

        public List<Article> GetArticles()
        {
            return _articleService.GetArticles();

        }

        public void UpdateArticleById(Article article, int Id)
        {
            _articleService.UpdateArticleById(article, Id);
        }
    }
}
