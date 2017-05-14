using HealthGuide.API.Metadata.Data;
using HealthGuide.API.Metadata.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HealthGuide.API.Metadata.Controllers
{
    [Route("[controller]")]
    [ResponseCache(Duration = 30)]
    public class LocationsController : Controller
    {
        private LocationsContext _locationsContext;

        public LocationsController(LocationsContext locationsContext)
        {
            _locationsContext = locationsContext;
        }

        [HttpGet]
        public IEnumerable<Location> Get()
        {
            return _locationsContext.Locations;
        }

        [HttpGet("{id}")]
        public Location Get(string id)
        {
            return _locationsContext.Locations.Find(location => location.Id == id);
        }
    }
}