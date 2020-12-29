using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Servak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // POST api/<AuthController>
        [HttpPost]
        public int Post([FromBody] AuthData authData)
        {
            int int_token = Program.Sessions.login(authData);
            Console.WriteLine(int_token);
            return int_token;
        }
    }
}
