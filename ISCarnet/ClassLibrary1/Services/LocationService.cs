using DataBaseLibrary.DTOs;
using DataBaseLibrary.Interfaces;
using DataBaseLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataBaseLibrary.Services
{
    public class LocationService : ILocationService
    {
        public readonly CandidateContext context;

        public LocationService(CandidateContext context)
        {
            this.context = context;
        }

        public bool LocationAlreadyExists(string locationName)
        {
            var location = context.Locations.FirstOrDefault(l => l.LocationName == locationName);
            if (location == null)
                return false;
            else
                return true;
        }

        public LocationDTO RegisterLocation(LocationDTO dto)
        {
            Location location = Location.Create(dto.LocationName, dto.Latitude, dto.Longitute);
            context.Locations.Add(location);
            context.SaveChanges();
            dto = new LocationDTO(location);
            return dto;
        }

        public List<LocationDTO> GetLocationDTOs()
        {
            List<LocationDTO> dtos = new List<LocationDTO>();

            foreach (Location location in context.Locations.ToList())
            {
                dtos.Add(new LocationDTO(location));
            }

            return dtos;
        }

        public Location GetLocationByName(string locationName)
        {
            var location = context.Locations.FirstOrDefault(l => l.LocationName == locationName);
            return location;
        }
    }
}
