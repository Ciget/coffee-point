using System;
using System.Threading.Tasks;
using CS.CoffePoint.Business.Entities;
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
        public void GetList_ShouldBeEmpty()
        {
            var collection = _repo.GetList();
            collection.Should().BeEmpty();
        }

        [Test]
        public async Task Add_ShouldCreateNewPlaceRecord()
        {
            var record = new PlaceEntity
            {
                Description = "Test entity",
                Id = Guid.NewGuid(),
                Title = "Sample",
                Location = new LocationEntity(10.22m, 44.53m)
            };

            var added = await _repo.Add(record);
            added.Resource.Should().NotBeNull();
        }
    }
}
