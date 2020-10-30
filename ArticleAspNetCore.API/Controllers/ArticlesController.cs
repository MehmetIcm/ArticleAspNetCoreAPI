using AricleApp.Domains;
using ArticleApp.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleAspNetCore.API.Controllers
{
    [Route("api/[controller]")]
    public class ArticlesController : ControllerBase
    {
        UnitOfWork unitOfWork = new UnitOfWork(new ArticleContext());

        [HttpGet]
        public List<Article> Get()
        {
            return unitOfWork.ArticleRepository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public Article GetById(int id)
        {
            return unitOfWork.ArticleRepository.GetById(id);
        }

        [HttpPost]
        public Article Post([FromBody] Article article)
        {
            unitOfWork.ArticleRepository.Add(article);
            unitOfWork.Complete();
            return article;
        }

        [HttpPut]
        public Article Put([FromBody] Article article)
        {
            unitOfWork.ArticleRepository.Update(article);
            unitOfWork.Complete();
            return article;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            unitOfWork.ArticleRepository.Remove(id);
            unitOfWork.Complete();
        }


    }
}
