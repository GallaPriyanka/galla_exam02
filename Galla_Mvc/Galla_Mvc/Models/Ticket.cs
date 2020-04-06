using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Galla_Mvc.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string TicketName { get; set; }
        public string Destination { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}