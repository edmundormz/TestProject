using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TestProject.Core;

namespace TestProject.Infrastructure
{
    public class ToyInitializeDB : DropCreateDatabaseAlways<ToyContext>
    {
        protected override void Seed(ToyContext context)
        {
            context.Toys.Add(new Toy
            {
                Id = 1,
                Name = "Iron Man",
                Price = 100,
                Description = "You know who it is",
                AgeRestriction = 0,
                Company = "Marvel"
            });

            context.Toys.Add(new Toy
            {
                Id = 2,
                Name="Captain America",
                Price =90,
                Description="Cheaper than Iron Man",
                AgeRestriction=0,
                Company="Marvel"
            });
            base.Seed(context);
        }
    }
}
