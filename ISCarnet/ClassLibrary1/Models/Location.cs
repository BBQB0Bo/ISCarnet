using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseLibrary.Models
{
    public class Location
    {
        public Guid LocationId { get; private set; }
        public string LocationName { get; private set; }
        public float Latitude { get; private set; }
        public float Longitute { get; private set; }

        public List<Exam> Exams { get; private set; }

        public Location()
        {
            this.Exams = new List<Exam>();
        }
        public static Location Create(string locationName, float latitude, float longitude)
        {
            Location location = new Location();
            location.LocationId = Guid.NewGuid();
            location.LocationName = locationName;
            location.Latitude = latitude;
            location.Longitute = longitude;
            return location;
        }

        public void AttachExam(Exam e)
        {
            this.Exams.Add(e);
        }

    }
}
