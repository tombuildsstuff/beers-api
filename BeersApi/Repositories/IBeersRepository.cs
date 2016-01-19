using System.Collections.Generic;
using BeersApi.Entities;

namespace BeersApi.Repositories
{
    public interface IBeersRepository
    {
        IEnumerable<Beer> GetAll();
    }
}