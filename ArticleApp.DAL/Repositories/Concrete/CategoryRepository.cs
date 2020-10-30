using AricleApp.Domains;
using ArticleApp.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleApp.DAL.Repositories.Concrete
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DAL.ArticleContext context):base(context)
        {

        }
        public IEnumerable<Category> GetCategoriesWithArticles()
        {
            return ArticleContext.Categories.Include("Articles").ToList();
        }

        public IEnumerable<Category> GetTopCategories(int count)
        {
            return ArticleContext.Categories.Take(count).ToList();

        }


        public DAL.ArticleContext ArticleContext { get { return _context as DAL.ArticleContext; } }
    }
}
