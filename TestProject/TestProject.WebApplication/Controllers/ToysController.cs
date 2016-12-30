using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestProject.Core;
using TestProject.Infrastructure;

namespace TestProject.WebApplication.Controllers
{
    public class ToysController : ApiController
    {
        ToyRepository repo; 

        // GET api/<controller>
        public IEnumerable<Toy> Get()
        {
            repo = new ToyRepository();
            var toys = repo.GetToys();
            return toys;
        }

        // GET api/<controller>/5
        public Toy Get(int id)
        {
            repo = new ToyRepository();
            var toyFound = repo.FindById(id);
            return toyFound;
        }

        // POST api/<controller>
        public void Post([FromBody]Toy newToy)
        {
            repo = new ToyRepository();
            repo.Add(newToy);
        }

        // PUT api/<controller>/5
        public void Put([FromBody]Toy toy)
        {
            repo = new ToyRepository();
            repo.Edit(toy);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            repo = new ToyRepository();
            repo.Remove(id);
        }
    }
}