using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Galla_Mvc.Models
{
    public class Passenger
    {
        public int PassengerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime TravelDate { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}