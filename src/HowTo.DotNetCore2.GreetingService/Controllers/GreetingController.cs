using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HowTo.DotNetCore2.GreetingService.Controllers
{
    [Route("api/v1/greeting")]
    public class GreetingController : Controller
    {
        [HttpGet]
        public IActionResult Get(string name)
        {
            return Ok($"Hello, {name}!");
        }
    }
}
