using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POC.OAuth2Provider.Models;

namespace POC.OAuth2Provider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OAuthController : ControllerBase
    {
        // GET: api/OAuth
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OAuth/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OAuth
        [HttpPost]
        public IActionResult Post([FromQuery] TokenRequest tokenRequest)
        {
			return Ok(new
			{
				access_token = "This is an access token",
				expires_in = 3600,
				token_type = "JWT",
			});
        }

        // PUT: api/OAuth/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
