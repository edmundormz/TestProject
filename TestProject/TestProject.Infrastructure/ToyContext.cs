using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Core;

namespace TestProject.Infrastructure
{
    public class ToyContext: DbContext
    {
        public ToyContext() : base("something json here"){ }
        public DbSet<Toy> Toys { get; set; }
    }
}
