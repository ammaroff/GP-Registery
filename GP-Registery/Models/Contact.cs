using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GP_Registery.Models
{
    public enum ContactType
    {
        Individual,
        Business,
        Govrenament
    }
    public class Contact
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public string Email { get; set; }
        public ContactType ContactType { get; set; }

        public virtual ICollection<Domain> Domains { get; set; }
    }
}