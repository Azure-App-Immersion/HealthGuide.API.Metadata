using HealthcareAPI.Data;
using HealthcareAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HealthcareAPI.Controllers
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
            return _locationsContext.Locations.Find(l => l.Id == id);
        }
    }
}