using System.Collections.Generic;

namespace OctaTech.Domain.Entity
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public string Model { get; set; }
        public List<Part> Parts { get; set; }
    }
}
