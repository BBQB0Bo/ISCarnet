using DataBaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseLibrary.DTOs
{
    public class LocationDTO
    {
        public string LocationName { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public LocationDTO() { }
        public LocationDTO(Location location)
        {
            this.LocationName = location.LocationName;
            this.Longitude = location.Longitude;
            this.Latitude = location.Latitude;
        }
    }
}
