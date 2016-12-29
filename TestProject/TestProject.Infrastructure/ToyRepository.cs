using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Core;
using TestProject.Core.Interfaces;

namespace TestProject.Infrastructure
{
    public class ToyRepository : IToy
    {
        ToyContext context = new ToyContext();

        //TODO Maybe change logic in methods for use with JSON
        public void Add(Toy t)
        {
            context.Toys.Add(t);
            context.SaveChanges();
        }

        public void Edit(Toy t)
        {
            context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            //TODO Add edit logic
        }

        public Toy FindById(int Id)
        {
            var result = (from x in context.Toys where x.Id == Id select x).FirstOrDefault();
            return result;
        }

        public IEnumerable<Toy> GetToys()
        {
            return context.Toys;
        }

        public void Remove(int Id)
        {
            Toy t = context.Toys.Find(Id);
            context.Toys.Remove(t);
            context.SaveChanges();
        }
    }
}
