using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Galla_Mvc.Models;

namespace Galla_Mvc.DAL
{
    public class TicketInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TicketContext>
    {
        protected override void Seed(TicketContext context)
        {
            var tickets = new List<Ticket>
            {
            new Ticket{TicketID=108,TicketName="Gouthami Express",Destination="Kolkata"},
            new Ticket{TicketID=100,TicketName="Kansas Passenger",Destination="Kansas"},
            new Ticket{TicketID=110,TicketName="Dallas Super Fast Express",Destination="Dallas"},
            new Ticket{TicketID=140,TicketName="Goods Train",Destination="Shimla"},
            new Ticket{TicketID=141,TicketName="MMTS Train",Destination="Lingampally"},
            new Ticket{TicketID=123,TicketName="Fulaknuma Express",Destination="Fulaknuma"},
            new Ticket{TicketID=121,TicketName="Sabari Express",Destination="Trivandrum"},
            new Ticket{TicketID=120,TicketName="Howrah Express",Destination="Delhi"}
            };

            tickets.ForEach(t => context.Tickets.Add(t));
            context.SaveChanges();
            var passengers = new List<Passenger>
            {
            new Passenger{PassengerID=1050,FirstName="Priyanka",LastName="Galla",TravelDate=DateTime.Parse("2005-09-01")},
            new Passenger{PassengerID=4022,FirstName="Naga Sai Manoj",LastName="Goppisetty",TravelDate=DateTime.Parse("2002-09-01")},
            new Passenger{PassengerID=4041,FirstName="Ravi Teja",LastName="Ravinoothala",TravelDate=DateTime.Parse("2003-09-01")},
            new Passenger{PassengerID=1045,FirstName="Dhanu",LastName="Galla1",TravelDate=DateTime.Parse("2002-09-01")},
            new Passenger{PassengerID=3141,FirstName="Samyuktha",LastName="Ilam",TravelDate=DateTime.Parse("2002-09-01")},
            new Passenger{PassengerID=2021,FirstName="Praveen",LastName="Ilam1",TravelDate=DateTime.Parse("2001-09-01")},
            new Passenger{PassengerID=2042,FirstName="Teja",LastName="Galla2",TravelDate=DateTime.Parse("2003-09-01")}
            };
            passengers.ForEach(p => context.Passengers.Add(p));
            context.SaveChanges();
            var bookings = new List<Booking>
            {
            new Booking{PassengerID=1050,TicketID=108},
            new Booking{PassengerID=1045,TicketID=120},
            new Booking{PassengerID=2042,TicketID=110},
            new Booking{PassengerID=1050,TicketID=123},
            new Booking{PassengerID=3141,TicketID=110},
            new Booking{PassengerID=1045,TicketID=141},
            new Booking{PassengerID=1045,TicketID=108},
            new Booking{PassengerID=4022,TicketID=141},
            new Booking{PassengerID=2042,TicketID=141},
            new Booking{PassengerID=4022,TicketID=120},
            new Booking{PassengerID=3141,TicketID=123},
            new Booking{PassengerID=4022,TicketID=141},
            };
            bookings.ForEach(b => context.Bookings.Add(b));
            context.SaveChanges();
        }
    }
}