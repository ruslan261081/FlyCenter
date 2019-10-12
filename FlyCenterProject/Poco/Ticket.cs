using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
   public class Ticket : IPoco
   {
        public long ID { get; set; }
        public long FlightID { get; set; }
        public long CustomerID { get; set; }

        public Ticket()
        {

        }

        public Ticket(long iD, long flightID, long customerID)
        {
            ID = iD;
            FlightID = flightID;
            CustomerID = customerID;
        }
        public static bool operator ==(Ticket me, Ticket other)
        {
            if (ReferenceEquals(me,other) || ReferenceEquals(me, null) && ReferenceEquals (other,null))
                return true;
            return false;
        }
        public static bool operator !=(Ticket me, Ticket other)
        {
            return !(me == other);
        }

        public override bool Equals(object obj)
        {
            Ticket otherTicket = obj as Ticket;
            return (this.ID == otherTicket.ID);
        }

        public override int GetHashCode()
        {
            return(int)this.ID;
        }

        public override string ToString()
        {
            return $"ID {ID} FlightID{FlightID} CustomerID {CustomerID}";
        }
    }
}
