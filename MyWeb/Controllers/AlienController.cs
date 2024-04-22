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
                new AlienModel()
                {Id=1,userdata = "A01",Type = "梅沙火星人", Name = "沼澤火",},    
                new AlienModel()
                {Id=2,userdata = "A02",Type = "變形外星人", Name = "異形怪",},
                new AlienModel()
                {Id=3,userdata = "A03",Type = "海空雙棲星人", Name = "魟人",},
                new AlienModel()
                {Id=4,userdata = "A04",Type = "索諾波波星人", Name = "小波波",},
                new AlienModel()
                {Id=5,userdata = "A05",Type = "海蟹甲布洛卡特斯星人", Name = "蟹甲智多星",},
                new AlienModel()
                {Id=6,userdata = "A06",Type = "瓦克斯薩瑞人", Name = "神力暴龍",},
                new AlienModel()
                {Id=7,userdata = "A07",Type = "佩卓沙皮星人", Name = "水晶奇俠",},
                new AlienModel()
                {Id=8,userdata = "A08",Type = "納克佛吉星人", Name = "寒冰幽靈",},
                new AlienModel()
                {Id=9,userdata = "A09",Type = "阿拉卡那星人", Name = "蜘蛛魔猴",},
                new AlienModel()
                {Id=10,userdata = "A10",Type = "天外天神族", Name = "X超人",},
                new AlienModel()
                {Id=11,userdata = "A11",Type = "圖庫斯塔人", Name = "超巨人",},
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
