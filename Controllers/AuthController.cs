using System;
using System.Security.Authentication;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GitTalk.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public object Get()
        {
            return new {
              Message = "I'm a teapot",
              Error = 418
            };
        }

        [HttpPost]
        public Authentication Post(string username, string password)
        {
          if (username == "kjellski") { 
return new Authentication {
              ID = "kjellski",
              Claims = new string[] {"Admin", "Moderator"},
              Token = Guid.NewGuid().ToString(),
            };
          }

          throw new AuthenticationException("You're not my master!");
        }
    }
}
