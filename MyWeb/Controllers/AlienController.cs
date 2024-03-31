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
    public class AlienController : ControllerBase
    {
        // GET: api/Alien
        [HttpGet]
        public IEnumerable<AlienModel> Get()
        {
            return new AlienModel[]
            {
                new AlienModel(){Id=1,userdata = "A01",Type = "梅沙火星人", Name = "沼澤火",}
            };
            
        }
        // GET: api/Alien/5
        [HttpGet("{userdata}")]
        public AlienModel Get(string userdata)
        {
            if (AlienModelFakeDB._dictionary.ContainsKey(userdata))
            {
                return AlienModelFakeDB._dictionary[userdata];
            }
            else
            {
                return null;
            }
        }

        // POST: api/Alien
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Alien/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Alien/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
