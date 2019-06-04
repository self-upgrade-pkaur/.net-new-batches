using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public partial class MoreInfo
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public DateTime? Dob { get; set; }
        public string Relationship { get; set; }
        public string Notes { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
