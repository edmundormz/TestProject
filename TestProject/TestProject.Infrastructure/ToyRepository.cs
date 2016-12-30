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
        
        public void Add(Toy t)
        {
            JArray toysArrary = JArray.Parse(File.ReadAllText(@"C:\Users\edmundo.ramirez\Documents\TestProject\TestProject\TestProject.Infrastructure\dataToys.json"));
            List<Toy> toys = toysArrary.ToObject<List<Toy>>();
            t.Id = toys.Max(x => x.Id) +1;
            toys.Add(t);
            string newToys = JsonConvert.SerializeObject(toys, Formatting.Indented);
            File.WriteAllText(@"C:\Users\edmundo.ramirez\Documents\TestProject\TestProject\TestProject.Infrastructure\dataToys.json", newToys);
        }

        public void Edit(Toy t)
        {
            JArray toysArrary = JArray.Parse(File.ReadAllText(@"C:\Users\edmundo.ramirez\Documents\TestProject\TestProject\TestProject.Infrastructure\dataToys.json"));
            List<Toy> toys = toysArrary.ToObject<List<Toy>>();
            Toy editToy = toys.Where(x => x.Id == t.Id).FirstOrDefault();
            if (editToy != null)
            {
                editToy.Name = t.Name;
                editToy.Description = t.Description;
                editToy.Price = t.Price;
                editToy.Company = t.Company;
                editToy.AgeRestriction = t.AgeRestriction;
                string newToys = JsonConvert.SerializeObject(toys, Formatting.Indented);
                File.WriteAllText(@"C:\Users\edmundo.ramirez\Documents\TestProject\TestProject\TestProject.Infrastructure\dataToys.json", newToys);
            }
            else
            {
                throw new Exception("Toy Not Found");
            }
        }

        public Toy FindById(int Id)
        {
            JArray toysArrary = JArray.Parse(File.ReadAllText(@"C:\Users\edmundo.ramirez\Documents\TestProject\TestProject\TestProject.Infrastructure\dataToys.json"));
            List<Toy> toys = toysArrary.ToObject<List<Toy>>();
            Toy foundToy = toys.Where(x => x.Id == Id).FirstOrDefault();
            return foundToy;
        }

        public List<Toy> GetToys()
        {
            JArray toysArrary = JArray.Parse(File.ReadAllText(@"C:\Users\edmundo.ramirez\Documents\TestProject\TestProject\TestProject.Infrastructure\dataToys.json"));
            List<Toy> toys = toysArrary.ToObject<List<Toy>>();
            return toys;
        }

        public void Remove(int Id)
        {
            JArray toysArrary = JArray.Parse(File.ReadAllText(@"C:\Users\edmundo.ramirez\Documents\TestProject\TestProject\TestProject.Infrastructure\dataToys.json"));
            List<Toy> toys = toysArrary.ToObject<List<Toy>>();
            toys.Remove(toys.Where(x => x.Id == Id).FirstOrDefault());
            string newToys = JsonConvert.SerializeObject(toys, Formatting.Indented);
            File.WriteAllText(@"C:\Users\edmundo.ramirez\Documents\TestProject\TestProject\TestProject.Infrastructure\dataToys.json", newToys);
        }
    }
}
