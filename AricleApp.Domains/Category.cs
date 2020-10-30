using System;
using System.Collections.Generic;
using System.Text;

namespace AricleApp.Domains
{
    public class Category
    {
        public Category()
        {
            Articles = new List<Article>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
