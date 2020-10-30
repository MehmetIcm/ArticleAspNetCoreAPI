using ArticleApp.DAL.Repositories.Abstract;
using ArticleApp.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private ArticleContext _articleContext;
        public UnitOfWork(ArticleContext context)
        {
            _articleContext = context;
            CategoryRepository = new CategoryRepository(_articleContext);
            ArticleRepository = new ArticleRepository(_articleContext);
        }
        public ICategoryRepository CategoryRepository { get;  set; }
        public IArticleRepository ArticleRepository { get;  set; }

        public int Complete()
        {
           return _articleContext.SaveChanges();
        }

        public void Dispose()
        {
            _articleContext.Dispose();
        }
    }
}
