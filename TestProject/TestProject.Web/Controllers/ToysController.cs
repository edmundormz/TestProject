using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestProject.Core;
using TestProject.Infrastructure;

namespace TestProject.Web.Controllers
{
    public class ToysController : ApiController
    {
        ToyRepository repo;
        
        public List<Toy> Get()
        {
            repo = new ToyRepository();
            var result = repo.GetToys();
            return result;
        }

        
        public Toy Get(int id)
        {
            repo = new ToyRepository();
            var result = repo.FindById(id);
            return result;
        }

        
        public void Post([FromBody]Toy t)
        {
            repo = new ToyRepository();
            repo.Add(t);
        }

        
        public void Put([FromBody]Toy t)
        {
            repo = new ToyRepository();
            repo.Edit(t);
        }


        public void Delete(int id)
        {
            repo = new ToyRepository();
            repo.Remove(id);
        }
    }
}
