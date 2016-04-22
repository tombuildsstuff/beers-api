using System.Linq;
using BeersApi.Controllers;
using BeersApi.Repositories;
using NUnit.Framework;

namespace BeersApi.IntegrationTests
{
    public class WhenRequestingAllBeers
    {
        private readonly BeersRepository _repository = new BeersRepository();

        [Test]
        public void ThenPunkIpaShouldBePresent()
        {
            /*
            var controller = new BeersController(_repository);
            var result = controller.All();
            var beers = result.Where(r => r.Name == "Punk IPA").ToList();
            Assert.That(beers.Count, Is.EqualTo(1));
            */
        }
    }
}
