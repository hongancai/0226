using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalController : ControllerBase
    {
        // GET: api/Pal
        [HttpGet]
        public IEnumerable<PalModel> Get()
        {
            return new PalModel[]
            {
            new PalModel(){Id = 2,Name = "空幹龍",Atk = 100,Def = 100,Spd = 100}
            };

        }

        // GET: api/Pal/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pal
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Pal/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Pal/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
