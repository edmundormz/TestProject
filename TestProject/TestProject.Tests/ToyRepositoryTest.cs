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
        }

        [TestMethod]
        public void SerializeObject()
        {
            Toy t = new Toy
            {
                Id = 1,
                Name = "Iron Man",
                Price = 90,
                AgeRestriction = 0,
                Description = "You know",
                Company = "Marvel"
            };
            var result = repo.Add(t);
            Assert.IsNotNull(result);
            }

        [TestMethod]
        public void GettingToys()
        {
            var result = repo.GetToys();
            Assert.IsNotNull(result);
            var countToys = repo.GetToys().Count;
            Assert.AreEqual(2, countToys);
        }
    }
}
