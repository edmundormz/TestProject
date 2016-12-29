using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Core.Interfaces
{
    public interface IToy
    {
        void Add(Toy t);
        void Edit(Toy t);
        void Remove(int Id);
        List<Toy> GetToys();
        Toy FindById(int Id);
    }
}
