using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public partial class Contact
    {
        public Contact()
        {
            Address = new HashSet<Address>();
            MoreInfo = new HashSet<MoreInfo>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Work { get; set; }
        public string Home { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<MoreInfo> MoreInfo { get; set; }
    }
}
