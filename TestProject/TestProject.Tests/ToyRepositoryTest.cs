using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.Infrastructure;
using System.Linq;
using TestProject.Core;

namespace TestProject.Tests
{
    [TestClass]
    public class ToyRepositoryTest
    {
        ToyRepository repo;

        [TestInitialize]
        public void TestSetup()
        {
            repo = new ToyRepository();
            var countId = repo.GetToys().Count;
        }

        [TestMethod]
        public void AddingToys()
        {
            Toy t = new Toy
            {
                Name = "Hulk",
                Price = 90,
                AgeRestriction = 0,
                Description = "You know",
                Company = "Marvel"
            };
            repo.Add(t);
            var result = repo.GetToys().Count;
            Assert.AreEqual(3,result);
            }

        [TestMethod]
        public void GettingToys()
        {
            var result = repo.GetToys();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EditToy()
        {
            Toy t = new Toy
            {
                Id = 2,
                Name = "Captain America",
                Price = 80,
                AgeRestriction = 0,
                Description = "Even Cheaper than Iron Man",
                Company = "Marvel"
            };
            repo.Edit(t);
            Toy editedToy = repo.FindById(t.Id);
            Assert.AreEqual(t.Price, editedToy.Price);
        }

        [TestMethod]
        public void DontRepeatIds()
        {
            var toys = repo.GetToys();
            var n = toys.GroupBy(x => x.Id).Count();
            var m = toys.Count;
            Assert.AreEqual(n, m);



        }

        [TestMethod]
        public void RemoveLastToy()
        {
            var lastId = repo.GetToys().Count;
            repo.Remove(lastId);
            var newLastId = repo.GetToys().Count;
            Assert.AreEqual(lastId - 1, newLastId);
        }
    }
}
