using Domain;
using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public string AddressType { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
