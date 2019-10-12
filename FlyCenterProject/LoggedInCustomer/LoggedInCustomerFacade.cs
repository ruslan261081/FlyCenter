using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
   public class LoggedInCustomerFacade : AnonymousUserFacade, ILoggedInCustomerFacade,IFacede
   {
        private new IAdministratorDAO _administratorDAO = new AdministratorDAOMSSQL();
        private new IAirlineDAO _airlineDAO = new AirlineDAOMSSQL();
        private new ICustomerDAO _customerDAO = new CustomerDAOMSSQL();
        private new ICountryDAO _countryDAO = new CountryDAOMSSQL();
        private new ITicketDAO _ticketDAO = new TicketDAOMSSQL();
        private new IFlightDAO _flightDAO = new FlightDAOMSSQL();

        public void CancelTicket(LoginToken<Customer> token, Ticket ticket)
        {
            if (UserIsValid(token) && token.User.Id == ticket.CustomerID)
            {
                _ticketDAO.Remove(ticket);
            }
        }

      
        public IList<Flight> GetAllMyFlights(LoginToken<Customer> token)
        {
            IList<Flight> flightsByCustomer = null;
            if(UserIsValid(token))
            {
                flightsByCustomer = _flightDAO.GetFlightsByCustomer(token.User);
            }
            return flightsByCustomer;
        }
        public long PurchaseTicket(LoginToken<Customer> token, Flight flihgt)
        {
            long newId = 0;
            if(UserIsValid(token))
            {
                if(flihgt.Remaining_Tickets > 0)
                {
                    newId = _ticketDAO.Add(new Ticket { CustomerID = token.User.Id, FlightID = flihgt.ID });
                    flihgt.Remaining_Tickets--;
                    _flightDAO.Update(flihgt);
                }
                else
                {
                    throw new TicketsIsOver("Sorry To try One's Luck Next Time");
                }
                
            }
            return newId;
        }
        public bool UserIsValid(LoginToken<Customer> token)
        {
            if (token != null && token.User != null)
                return true;
            return false;
        }
    }
}
