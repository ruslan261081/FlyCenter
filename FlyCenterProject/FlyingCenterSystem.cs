using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlyCenterProject
{
   public class FlyingCenterSystem
   {
        private static FlyingCenterSystem _FlyingCenterInstance;
        private static object key = new object();

        protected FlyingCenterSystem()
        {
            new Task(() =>
            {
                TicketHistory();
                FlightsHistory();

                Thread.Sleep(FlightCenterConfig.ONEDAY_INTERVAL);

            });

        }
        public static FlyingCenterSystem GetInstance()
        {
          
            if(_FlyingCenterInstance == null)
            {
                lock(key)
                {
                    if(_FlyingCenterInstance == null)
                    {
                        _FlyingCenterInstance = new FlyingCenterSystem();
                    }
                }
            }
            return _FlyingCenterInstance;
        }
        public ILoginToken Login(string userName, string Password)
        {
            LoginService loginService = new LoginService();

            if(loginService.TryAdminLogin(userName,Password, out LoginToken<Administrator> AdminToken))
            {
                return AdminToken;
            }
            else if (loginService.TryAirlineLogin(userName,Password, out LoginToken<AirlineCompany> AirlineCompanyToken))
            {
                return AirlineCompanyToken;
            }
            else
            {
                return null;
            }

        }
        public  IFacede GetFacede(ILoginToken loginToken)
        {
            
        
            if (loginToken == null)
            {
                return new LoggedInAdministratorFacede();
            }
            if(loginToken.GetType() == typeof(LoginToken<Administrator>))
            {
                return new LoggedInAdministratorFacede();
            }
            if(loginToken.GetType() == typeof(LoginToken<Customer>))
            {
                return new LoggedInCustomerFacade();
            }
            if (loginToken.GetType() == typeof(LoginToken<AirlineCompany>))
            {
                return new LoggedInAirlineFacade();
            }
                return new AnonymousUserFacade();
        }
        public IList<Ticket> TicketHistory()
        {
            DateTime ThreeHoursAfter = DateTime.Now.Subtract(DateTime.Now.AddHours(3) - DateTime.Now);
            string threeHoursAfter = ThreeHoursAfter.ToString("yyyy-MM-dd HH:mm:ss");

            List<Ticket> list = new List<Ticket>();

            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_ALL_TICKETS_AFTER_3_HOURS", connection);
                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.Default);
                while(reader.Read() == true)
                {
                    Ticket ticket = new Ticket();
                    ticket.ID = (long)reader["ID"];
                    ticket.FlightID = (long)reader["FLIGHT_ID"];
                    ticket.CustomerID = (long)reader["CUSTOMER_ID"];
                    list.Add(ticket);
                }
                cmd.Connection.Close();
                return list;
               
            }
           
        }
        public IList<Flight> FlightsHistory()
        {
            DateTime ThreeHoursAfter = DateTime.Now.Subtract(DateTime.Now.AddHours(3) - DateTime.Now);
            string threeHoursAfter = ThreeHoursAfter.ToString("yyyy-MM-dd HH:mm:ss");

            List<Flight> list = new List<Flight>();

            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_ALL_FLIGHT_AFTER_3_HOURS", connection);
                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Clear();

                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.Default);
                while (reader.Read() == true)
                {
                    Flight flihgt = new Flight();
                    flihgt.ID = (long)reader["ID"];
                    flihgt.AirlineCompany_Id = (long)reader["AIRLINECOMPANY_ID"];
                    flihgt.Origin_Country_Code = (long)reader["ORIGIN_COUNTRY_CODE"];
                    flihgt.Destination_Country_Code = (long)reader["DESTINATION_COUNTRY_CODE"];
                    flihgt.Departure_Time = (DateTime)reader["DEPARTURE_TIME"];
                    flihgt.Landing_Time = (DateTime)reader["LANDING_TIME"];
                    flihgt.Remaining_Tickets = (int)reader["REMAINING_TICKETS"];
                    list.Add(flihgt);


                }
                cmd.Connection.Close();
                return list;

            }
        }
    }
}
