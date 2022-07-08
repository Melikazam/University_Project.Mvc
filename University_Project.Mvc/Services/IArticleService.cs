using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using University_Project.Mvc.Models;

namespace University_Project.Mvc.Services
{
    public interface IArticleService
    {
        List<Article> GetArticles();
        Article GetArticleById(int id);
        void CreateArticle(Article article);
        void DeleteArticleById(int id);
        void UpdateArticleById(Article article, int Id);
    }
}
