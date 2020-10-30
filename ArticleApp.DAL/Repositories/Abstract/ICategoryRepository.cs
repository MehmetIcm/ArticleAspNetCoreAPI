using AricleApp.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DAL.Repositories.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        IEnumerable<Category> GetTopCategories(int count);
        IEnumerable<Category> GetCategoriesWithArticles();
    }
}
