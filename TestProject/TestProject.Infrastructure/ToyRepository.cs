using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Core;
using TestProject.Core.Interfaces;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TestProject.Infrastructure
{
    public class ToyRepository : IToy
    {

        //TODO Maybe change logic in methods for use with JSON
        public string Add(Toy t)
        {
            string output = JsonConvert.SerializeObject(t);
            return output;
        }

        public void Edit(Toy t)
        {
        }

        public Toy FindById(int Id)
        {
            Toy toy = new Toy();
            return toy;
        }

        public List<Toy> GetToys()
        {
            JArray toysArrary = JArray.Parse(File.ReadAllText(@"C:\Users\edmundo.ramirez\Documents\TestProject\TestProject\TestProject.Infrastructure\dataToys.json"));
            List<Toy> toys = toysArrary.ToObject<List<Toy>>();
            return toys;
        }

        public void Remove(int Id)
        {
        }
    }
}
