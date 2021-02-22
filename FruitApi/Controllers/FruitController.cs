using FruitApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FruitApi.Controllers
{
    [RoutePrefix("api/Fruit")]
    public class FruitController : ApiController
    {
        [HttpGet]
        [Route("All")]
        public async Task<List<Fruit>> GetAll()
        {
            return InMemoryDB.Fruit;
        }

        [HttpPost]
        [Route("AddFruit")]
        public async Task AddFruit(Fruit fruit)
        {
            if (InMemoryDB.Fruit == null)
            {
                InMemoryDB.Fruit = new List<Fruit>();
            }

            InMemoryDB.Fruit.Add(fruit);
        }


        [HttpPut]
        [Route("EditFruit")]
        public async Task EditFruit(Fruit fruit)
        {
            if (InMemoryDB.Fruit == null)
            {
                return;
            }

            Fruit existingFruit = InMemoryDB.Fruit.FirstOrDefault(x => x.Name == fruit.Name);

            if (existingFruit != null)
            {
                existingFruit.Weight = fruit.Weight;
                existingFruit.Color = fruit.Color;
            }

        }
    }
}
