using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HowTo.DotNetCore2.GreetingService.Controllers
{
    [Route("api/v1/greeting")]
    public class GreetingController : Controller
    {
        /// <summary>
        /// Gets a greeting string
        /// </summary>
        /// <remarks>Pass your name and get a greeting</remarks>
        /// <response code="200">Your request successfully processed</response>
        /// <response code="500">Oups! Something went wrong</response>
        [HttpGet]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.InternalServerError)]
        public IActionResult Get([FromQuery] string name)
        {
            return Ok($"Hello, {name}!");
        }
    }
}
