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
                Id = 3,
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
            var countToys = repo.GetToys().Count;
            Assert.AreEqual(2, countToys);
        }

        [TestMethod]
        public void DontRepeatIds()
        {

        }
    }
}
