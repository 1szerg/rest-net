using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HeroesController : ApiController
    {
        // GET: api/Heroes
        public IList<Hero> Get()
        {
            return HeroesStorage.getInstance().getAll();
        }

        // GET: api/Heroes/{id}
        public string Get(int id)
        {
            return HeroesStorage.getInstance().getHero(id);
        }

        // POST: api/Heroes/
        public void Post([FromBody] string name)
        {
            HeroesStorage.getInstance().updateHero(-1, name);
        }

        // PUT: api/Heroes/
        public void Put([FromBody]int id, [FromBody]string name)
        {
            HeroesStorage.getInstance().updateHero(id, name);
        }

        // DELETE: api/Heroes/
        public void Delete([FromBody] int id)
        {
            HeroesStorage.getInstance().removeHero(id);
        }
    }
}
