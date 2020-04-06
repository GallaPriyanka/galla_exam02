using Galla_Mvc.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Galla_Mvc.DAL
{
    public class TicketContext : DbContext
    {

        public TicketContext() : base("TicketContext")
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Passenger> Passengers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}