using ArticleApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; set; }
        IArticleRepository ArticleRepository { get; set; }
        int Complete();
    }
}
