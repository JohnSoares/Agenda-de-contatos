using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace agenda_de_contatos.Models
{
    public class ContactScheduleContext : DbContext
    {
        public ContactScheduleContext() : base("ContactSchedule")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}