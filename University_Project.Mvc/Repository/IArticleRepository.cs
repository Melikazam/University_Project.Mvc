using System.Collections.Generic;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Repository
{
    public interface IArticleRepository
    {
        void CreateArticle(Article article);
        void DeleteArticleById(int id);
        Article GetArticleById(int id);
        List<Article>GetArticles();
        void UpdateArticleById(Article article, int id);

    }
}
