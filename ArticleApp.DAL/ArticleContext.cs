using AricleApp.Domains;
using Microsoft.EntityFrameworkCore;
using System;

namespace ArticleApp.DAL
{
    public class ArticleContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; database=ArticleDb; integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
