using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantClient.Models
{
    public class Location
    {
        public int id { get; set; }
        public int RestaurantId { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string  ZipCode { get; set; }
    }
}
