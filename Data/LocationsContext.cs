using HealthGuide.API.Metadata.Models;
using System.Collections.Generic;

namespace HealthGuide.API.Metadata.Data
{
    public class LocationsContext
    {
        public LocationsContext()
        {
            Locations = new List<Location>
            {
                new Location 
                { 
                    Id = "sanford-general-practice", 
                    Name =  "Sanford General Practice" 
                },
                new Location 
                { 
                    Id =  "open-clinic-northwest-portland", 
                    Name =  "Open Clinic of Northwest Portland" 
                },
                new Location 
                { 
                    Id =  "eastern-lewiston-medical-center", 
                    Name =  "Eastern Lewiston Medical Center" 
                }            
            };
        }

        public List<Location> Locations { get; private set;}
    }
}