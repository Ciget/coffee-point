using CS.CoffePoint.Business.Repositories;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace CS.CoffeePoint.Tests
{
    [TestFixture]
    public class PlaceRepositoryTest : BaseTest
    {
        private PlaceRepository _repo;
        
        [SetUp]
        public void Setup()
        {
            _repo = new PlaceRepository(Configuration);
        }

        [Test]
        public void Test1()
        {
            var collection = _repo.GetList();
            collection.Should().BeEmpty();
        }
    }
}
