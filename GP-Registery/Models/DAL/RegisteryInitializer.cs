using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GP_Registery.Models;

namespace GP_Registery.DAL
{
    public class RegisteryInitializer : DropCreateDatabaseIfModelChanges<RegisteryDBContext>
    {
        protected override void Seed(RegisteryDBContext context)
        {
            var contacts = new List<Contact>
            {
                new Contact{ID=1,Name="Egypt Government",Address="Dokki",Email="admin@eg.gov.eg",ContactType = ContactType.Govrenament},
                new Contact{ID=2,Name="Vodafone",Address="6th of Octobar",Email="admin@vodafone.com.eg",ContactType = ContactType.Business},
                new Contact{ID=3,Name="Mobinil",Address="Maadi",Email="admin@mobinil.com",ContactType = ContactType.Business},
                new Contact{ID=4,Name="Mohamed Ali",Address="Naser City",Email="Mohamed@gmail.com",ContactType = ContactType.Individual}
            };
            context.Contacts.AddRange(contacts);
            context.SaveChanges();

            var domains = new List<Domain>
            {
                new Domain{DomainName="bawaba.com.eg",CreationDate=new DateTime(2000,1,1),ExpirationDate=new DateTime(2016,1,1),Status=Status.Online,ContactID=1},
                new Domain{DomainName="vodafone.com.eg",CreationDate=new DateTime(2000,1,1),ExpirationDate=new DateTime(2016,1,1),Status=Status.Online,ContactID=2},
                new Domain{DomainName="mobinil.com",CreationDate=new DateTime(2000,1,1),ExpirationDate=new DateTime(2016,1,1),Status=Status.Online,ContactID=3},
                new Domain{DomainName="swalif.com",CreationDate=new DateTime(2000,1,1),ExpirationDate=new DateTime(2016,1,1),Status=Status.Online,ContactID=4},
                new Domain{DomainName="fenon.com",CreationDate=new DateTime(2000,1,1),ExpirationDate=new DateTime(2016,1,1),Status=Status.Online,ContactID=4},

            };
            context.Domains.AddRange(domains);
            context.SaveChanges();
        }
    }
}