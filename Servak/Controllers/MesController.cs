using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Servak;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Servak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesController : ControllerBase
    {
        static MessageClass mc = new MessageClass();

        // GET api/<MesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> Get(int id)
        {
            string json = " Not found. ";
            if ((id < mc.CountMes()) && (id >= 0))
            {
                json = JsonSerializer.Serialize(mc.Get(id));
                return json.ToString();
            }
            return NotFound();
        }

        // POST api/<MesController>
        [HttpPost]
        public void Post([FromBody] Message txt)
        {
            mc.Add(txt);
            Console.WriteLine($"({mc.Data.Count-1}) User {txt.UserName} posted: {txt.Text}    {txt.TimeStamp} ");
        }

    }
}
