using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BeersApi.Repositories;
using Newtonsoft.Json;

namespace BeersApi.Controllers
{
    public class BeersController : ApiController
    {
        private readonly IBeersRepository _repository;

        public BeersController(IBeersRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public HttpResponseMessage All()
        {
            // TODO: complex business logic..
            var beers = _repository.GetAll().ToList();
            return Request.CreateResponse(HttpStatusCode.OK, beers);
        }
    }
}