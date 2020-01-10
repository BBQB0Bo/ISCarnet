using DataBaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseLibrary.DTOs
{
    public class LocationDTO
    {
        public string LocationName { get; private set; }
        public float Latitude { get; private set; }
        public float Longitute { get; private set; }

        public LocationDTO() { }
        public LocationDTO(Location location)
        {
            this.LocationName = location.LocationName;
            this.Longitute = location.Longitute;
            this.Latitude = location.Latitude;
        }
    }
}
