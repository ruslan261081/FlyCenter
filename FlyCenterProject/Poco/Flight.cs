using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
    public class Flight : IPoco
    {
        public long ID { get; set; }
        public long AirlineCompany_Id { get; set; }
        public long Origin_Country_Code { get; set; }
        public long Destination_Country_Code { get; set; }
        public DateTime Departure_Time { get; set; }
        public DateTime Landing_Time { get; set; }
        public int Remaining_Tickets { get; set; }

        public Flight()
        {

        }

        public Flight(long id, long airlineCompany_Id, long origin_Country_Code, long destination_Country_Code, DateTime departure_Time, DateTime landing_Time, int remaining_Tickets)
        {
            ID = id;
            AirlineCompany_Id = airlineCompany_Id;
            Origin_Country_Code = origin_Country_Code;
            Destination_Country_Code = destination_Country_Code;
            Departure_Time = departure_Time;
            Landing_Time = landing_Time;
            Remaining_Tickets = remaining_Tickets;
        }
        public static bool operator ==(Flight me, Flight other)
        {
            if (ReferenceEquals(me,other) || ReferenceEquals(me, null) && ReferenceEquals(other, null))
                return true;
            return false;
           
        }
        public static bool operator !=(Flight  me, Flight other)
        {
            return !(me == other);
        }
        public override bool Equals(object obj)
        {
           
            Flight otherFlight = obj as Flight ;
            return (this.ID == otherFlight.ID);
        }

        public override int GetHashCode()
        {
            return(int)this.ID;
        }

        public override string ToString()
        {
            return $" Flight Id {ID}, Airline Id {AirlineCompany_Id}, OriginCountryCode {Origin_Country_Code},DestinationCountryCode {Destination_Country_Code},  DepartureTime {Departure_Time},LandingTime {Landing_Time}RemainingTickets {Landing_Time}";
        }
    }
   


  
   
}

