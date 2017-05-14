using HealthcareAPI.Data;
using HealthcareAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HealthcareAPI.Controllers
{
    [Route("[controller]")]
    [ResponseCache(Duration = 30)]
    public class DoctorsController : Controller
    {
        private DoctorsContext _doctorsContext;

        public DoctorsController(DoctorsContext doctorsContext)
        {
            _doctorsContext = doctorsContext;
        }

        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return _doctorsContext.Doctors;
        }

        [HttpGet("{id}")]
        public Doctor Get(string id)
        {
            return _doctorsContext.Doctors.Find(doctor => doctor.Id == id);
        }
    }
}