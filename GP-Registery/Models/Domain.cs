using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GP_Registery.Models
{
    public enum Status
    {
        Online
    }
        public class Domain
        {
            public int ID { get; set; }
            public string DomainName { get; set; }
            public DateTime ExpirationDate { get; set; }
            public DateTime CreationDate { get; set; }

            public Status Status { get; set; }

            public  int ContactID { get; set; }
            
            public virtual Contact Contact { get; set; }

            public virtual ICollection<NameServer> NameServer { get; set; }
        }
    
}