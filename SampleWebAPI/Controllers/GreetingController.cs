using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "No Input";
        }
        [HttpGet("{greet}/{name}")]
        public ActionResult<string> Get(string greet, string name)
        {
            return greet == "Hello" ? $"Hi {name}" : "Invalid Input";
        }
    }
}