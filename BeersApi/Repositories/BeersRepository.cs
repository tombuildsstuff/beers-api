using System.Collections.Generic;
using BeersApi.Entities;

namespace BeersApi.Repositories
{
    public class BeersRepository : IBeersRepository
    {
        public IEnumerable<Beer> GetAll()
        {
            return new List<Beer>
            {
                new Beer("Camden Brewery", "Camden Hells"),
                new Beer("Brewdog", "Punk IPA"),
            };
        }
    }
}