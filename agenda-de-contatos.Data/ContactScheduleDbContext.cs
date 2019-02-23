using agenda_de_contatos.Domain;
using System.Data.Entity;

namespace agenda_de_contatos.Data
{
    public class ContactScheduleDbContext : DbContext
    {
        public ContactScheduleDbContext() : base("Name-ContactSchedule")
        {
            Database.SetInitializer<ContactScheduleDbContext>(new CreateDatabaseIfNotExists<ContactScheduleDbContext>());
            Database.Initialize(false);
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ContactTelephone> ContactTelephones { get; set; }
    }
}
