using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLib.Model;

namespace AfleveringOpgave4.Controllers
{
    [Route("api/Books")]
    [ApiController]
    public class BogController : ControllerBase
    {
        private static readonly List<Bog> items = new List<Bog>()
        {
          new Bog("1111111111111", "Daniel",10),
          new Bog("2222222222222", "Daniel",20),
          new Bog("3333333333333", "Magnus",30),
          new Bog("4444444444444", "Jacob",40),
          new Bog("5555555555555", "Osman",60),



        };
        // GET: api/Items
        [HttpGet]
        public IEnumerable<Bog> Get()
        {
            return items;
        }

        // GET: api/Items/5
        //[HttpGet("{id}", Name = "Get")]
        [HttpGet]
        [Route("{id}")]
        public Bog Get(string isbn13)
        {
            return items.Find(i => i.Isbn13 == isbn13);
        }

        // POST: api/Items
        [HttpPost]
        public void Post([FromBody] Bog value)
        {
            items.Add(value);
        }

        // PUT: api/Items/5
        //[HttpPut("{id}")]
        [HttpPut]
        [Route("{id}")]
        public void Put(string id, [FromBody] Bog value)
        {
            Bog item = Get(id);
            if (item != null)
            {
                item.Isbn13 = value.Isbn13;
                item.Forfatter = value.Forfatter;
                item.Sidetal = value.Sidetal;

            }
        }

        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        [HttpDelete]
        [Route("{id}")]
        public void Delete(string id)
        {
            Bog item = Get(id);
            items.Remove(item);
        }

        [HttpGet]
        [Route("FromAuthorDaniel")]
        public IEnumerable<Bog> FromAuthorDaniel(String substring)
        {
            return items.FindAll(i => i.Forfatter.Contains("Daniel"));
        }
    }
}
