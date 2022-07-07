using System.Collections.Generic;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Repository
{
    public interface IArticleRepository
    {
        void AddArticle(Article article);
        void DeleteArticle(Article article);
        Article GetArticle(int id);
        List<Article>GetArticles();
        void UpdateArticle();

    }
}
