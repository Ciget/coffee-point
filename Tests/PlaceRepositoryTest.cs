using CS.CoffePoint.Business.Repositories;
using NUnit.Framework;

namespace CS.CoffeePoint.Tests
{
    [TestFixture]
    public class PlaceRepositoryTest : BaseTest
    {
        private PlaceRepository _repo;

        [Test]
        public void Test1()
        {
           var t=  ServiceProvider.GetService(typeof(IPlaceRepository));
            //_repo = new PlaceRepository(
            //    );
        }
    }
}
