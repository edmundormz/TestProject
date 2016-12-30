using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestProject.Core;
using TestProject.Infrastructure;
using Unosquare.Tubular;

namespace TestProject.WebApp.Controllers
{
    public class ToyController : ApiController
    {
        ToyRepository repo; 

        // GET api/<controller>
        [HttpPost]
        public List<Toy> GetToys([FromBody] GridDataRequest model)
        {
            repo = new ToyRepository();
            var toys = repo.GetToys();
            return toys;
        }

        // GET api/<controller>/5
        public Toy GetById(int Id)
        {
            repo = new ToyRepository();
            var foundToy = repo.FindById(Id);
            return foundToy;
        }

        // POST api/<controller>
        public void PostToy([FromBody]Toy newToy)
        {
            repo = new ToyRepository();
            repo.Add(newToy);
        }

        // PUT api/<controller>/5
        public void Put([FromBody]Toy editedToy)
        {
            repo = new ToyRepository();
            repo.Edit(editedToy);
        }

        // DELETE api/<controller>/5
        public void Delete(int Id)
        {
            repo = new ToyRepository();
            repo.Remove(Id);
        }
    }
}