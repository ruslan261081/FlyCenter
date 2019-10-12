using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
 public interface IAnonymousUserFacade
 {
        IList<Flight> GetAllFlights();
        IList<AirlineCompany> GetAllAirlineCompanies();
        Dictionary<Flight, int> GetAllFlightsVacancy();
        Flight GetFlightById(int id);
        IList<Flight> GetFlightsByOriginCountry(int countryCode);
        IList<Flight> GetFlightsByDestinationCountry(int countryCode);
        IList<Flight> GetFlightsByDepatruteDate(DateTime departureDate);
        IList<Flight> GetFlightsByLandingDate(DateTime landingDate);
        
 }
}
