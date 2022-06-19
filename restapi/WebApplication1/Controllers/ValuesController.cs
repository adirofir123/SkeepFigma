using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("GetData")]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet("[action]")]
        public IEnumerable<string> Getblocksdata()
        {
            return new string[] { "7,500", "$1,247", "$120" };
        }



        // GET api/<UserController>/5
        [HttpGet]
        [Route("[action]")]
        public IEnumerable<string> Getbarchartdata()
        {
            return new string[] { "7526", "5840", "4282","3840","3356","3024","2721","2238","1845","1064" };

        }

        // GET api/<UserController>/5
        [HttpGet]
        [Route("[action]")]
        public IEnumerable<string> Getdonutchartdata()
        {
            return new string[] { "40", "20", "7" };

        }


        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
