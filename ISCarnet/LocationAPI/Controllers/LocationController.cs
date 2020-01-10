using Microsoft.AspNetCore.Mvc;
using DataBaseLibrary.DTOs;
using DataBaseLibrary.Models;
using DataBaseLibrary.Interfaces;
using System.Collections.Generic;

namespace LocationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LocationController : ControllerBase
    {
        private readonly ILocationService service;

        public LocationController(ILocationService service)
        {
            this.service = service;
        }

        // POST: api/Location
        [HttpPost]
        public ActionResult<Location> PostLocation([FromBody] LocationDTO dto)
        {
           if(service.LocationAlreadyExists(dto.LocationName))
                return BadRequest();
            LocationDTO location = service.RegisterLocation(dto);
            return Ok(location);
        }



        // GET: api/Locations
        public ActionResult<List<LocationDTO>> GetLocations()
        {
            List<LocationDTO> dtos = service.GetLocationDTOs();

            if (dtos.Count == 0)
                return NoContent();
            else return Ok(dtos);
        }


        // GET: api/Locations
        [HttpGet("{locationName}")]
        public ActionResult<Location> GetLocationByName(string locationName)
        {
            var location = service.GetLocationByName(locationName);
            if (location == null)
                return NotFound();
            else return Ok(new LocationDTO(location));
        }
    }
}
