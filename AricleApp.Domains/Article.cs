using System;

namespace AricleApp.Domains
{
    public class Article:BaseEntity
    {
        public int Id { get; set; }
        public string ArticleContent { get; set; }

        public Category Categories { get; set; }
    }
}
