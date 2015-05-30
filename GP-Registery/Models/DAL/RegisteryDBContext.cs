using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using GP_Registery.Models;

namespace GP_Registery.DAL
{
    public class RegisteryDBContext :DbContext
    {
        public RegisteryDBContext()
            :base("RegisteryDBContext")
        {
            Console.WriteLine(this.Database.Connection.ConnectionString);

        }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<NameServer> NameServers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}