using HealthGuide.API.Metadata.Models;
using System.Collections.Generic;

namespace HealthGuide.API.Metadata.Data
{
    public class DoctorsContext
    {
        public DoctorsContext()
        {
            Doctors = new List<Doctor>
            {
                new Doctor
                {
                    Id = "aguilar-trevino",
                    Name = "Aguilar Trevino"
                },
                new Doctor
                {
                    Id = "marguerite-greer",
                    Name = "Marguerite Greer"                    
                },
                new Doctor
                {
                    Id = "lambert-neal",
                    Name = "Lambert Neal"
                },
                new Doctor
                {
                    Id = "shawna-church",
                    Name = "Shawna Church"
                }
            };
        }

        public List<Doctor> Doctors { get; private set; }
    }
}