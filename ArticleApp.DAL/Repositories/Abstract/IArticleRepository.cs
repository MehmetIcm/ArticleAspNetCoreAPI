using AricleApp.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DAL.Repositories.Abstract
{
    public interface IArticleRepository : IRepository<Article>
    {
        IEnumerable<Article> GetArticlesWithCategories();
    }
}
