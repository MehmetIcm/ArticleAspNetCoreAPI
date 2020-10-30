using AricleApp.Domains;
using ArticleApp.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ArticleApp.DAL.Repositories.Concrete
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(ArticleContext context):base(context)
        {

        }
        public IEnumerable<Article> GetArticlesWithCategories()
        {
            return ArticleContext.Articles.Include("Category").ToList();
        }

        public ArticleContext ArticleContext { get { return _context as ArticleContext; } }
    }
}