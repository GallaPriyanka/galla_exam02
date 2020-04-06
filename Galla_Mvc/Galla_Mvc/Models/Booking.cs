using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Galla_Mvc.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int PassengerID { get; set; }
        public int TicketID { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}