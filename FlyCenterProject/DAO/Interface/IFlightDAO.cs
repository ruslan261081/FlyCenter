using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
   public interface IFlightDAO : IBasicDB<Flight>
   {
       Dictionary<Flight, int> GetAllFlightsVacancy();
       IList <Flight>GetFlightsByCustomer(Customer customer);
       IList <Flight> GetFlightsByDepartureDate(DateTime departureDate);
       IList <Flight> GetFlightsByDestinationCountry(int countryCode);
       IList <Flight> GetFlightsByLandingDate(DateTime landingDate);
       IList <Flight> GetFlightsByOriginCountry(int countryCode);
       IList<Flight> GetFlightsByAirlineCompany(AirlineCompany airline);
   }
}
