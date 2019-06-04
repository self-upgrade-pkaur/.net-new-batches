using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        private string _firstName;
        public string FirstName { get => _firstName; set {
                if (_firstName.Length==0)
                {
                    throw new ArgumentException("First name cannot be empty ", nameof(value));
                }
                _firstName = value;
            }
        }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Work { get; set; }
        public string Home { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }

        public virtual List<Address> Address { get; set; } = new List<Address>();
        public virtual ICollection<MoreInfo> MoreInfo { get; set; }
    }
}
