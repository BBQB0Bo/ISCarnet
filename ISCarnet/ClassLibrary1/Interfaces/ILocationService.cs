using DataBaseLibrary.DTOs;
using DataBaseLibrary.Models;
using System.Collections.Generic;

namespace DataBaseLibrary.Interfaces
{
    public interface ILocationService
    {   
        public bool LocationAlreadyExists(string locationName);

        public LocationDTO RegisterLocation(LocationDTO dto);

        public List<LocationDTO> GetLocationDTOs();

        public Location GetLocationByName(string locationName);
    }
}
