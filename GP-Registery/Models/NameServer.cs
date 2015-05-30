using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GP_Registery.Models
{
    public class NameServer
    {
        public int ID { get; set; }
        public int DomainID { get; set; }
        public string Prefix { get; set; }
        public string IPAddress { get; set; }

        public virtual Domain Domain { get; set; }
    }

}