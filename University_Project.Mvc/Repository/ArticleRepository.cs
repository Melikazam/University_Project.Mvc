using System.Collections.Generic;
using System.Linq;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly AppDbContext _context;

        public ArticleRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddArticle(Article article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();
        }

        public void DeleteArticle(Article article)
        {
            _context.Articles.Remove(article);
            _context.SaveChanges();
        }

        public Article GetArticle(int id)
        {
            return _context.Articles.FirstOrDefault(u => u.Id == id);
        }

        public List<Article> GetArticles()
        {
            return _context.Articles.ToList();
        }

        public void UpdateArticle(Article article, int id)
        {
            Article temp = _context.Articles.FirstOrDefault(u => u.Id == id);
            if (temp != null)
            {
                temp.Stock = article.Stock;
                //temp.ProductID = article.ProductID;
            }
            _context.SaveChanges();
        }
    }
}