using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticeAppAspNetCoreUI.Controllers
{
    [Route("Articles")]
    public class ArticlesControllers:ControllerBase
    {
        [Route("Hello")]
        public string Hello()
        {
            return "Hello";
        }
    }
}
