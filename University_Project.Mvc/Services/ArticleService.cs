using System.Collections.Generic;
using University_Project.Mvc.Models;
using University_Project.Mvc.Repository;

namespace University_Project.Mvc.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void CreateArticle(Article article)
        {
            _articleRepository.CreateArticle(article);
        }

        public void DeleteArticleById(int id)
        {
            _articleRepository.DeleteArticleById(id);
        }

        public Article GetArticleById(int id)
        {
            return _articleRepository.GetArticleById(id);

        }

        public List<Article> GetArticles()
        {
            return _articleRepository.GetArticles();

        }

        public void UpdateArticleById(Article article, int Id)
        {
            _articleRepository.UpdateArticleById(article, Id);
        }
    }
}
