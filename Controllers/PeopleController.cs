using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GitTalk.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PeopleController> _logger;

        public PeopleController(ILogger<PeopleController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            var rng = new Random();
            var uuid = Guid.NewGuid().ToString();
            var shortUuid = uuid.Split("-").Last().ToString();
            return Enumerable.Range(1, 5).Select(index => new Person
            {
                ID = uuid,
                FirstName = $"{shortUuid}_FirstName",
                LastName = $"{shortUuid}_LastName",
                Age= rng.Next()
            }).ToArray();
        }
    }
}
