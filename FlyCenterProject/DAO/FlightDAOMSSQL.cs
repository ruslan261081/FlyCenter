﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
   public class FlightDAOMSSQL : IFlightDAO
   {
        public long Add(Flight t)
        {
            long newId = 0;
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("ADD_FLIGHT", connection);
                cmd.Parameters.Add(new SqlParameter("@AIRLINECOMPANY_ID", t.AirlineCompany_Id));
                cmd.Parameters.Add(new SqlParameter("ORIGIN_COUNTRY_CODE", t.Origin_Country_Code));
                cmd.Parameters.Add(new SqlParameter("@DESTINATION_COUNTRY_CODE", t.Destination_Country_Code));
                cmd.Parameters.Add(new SqlParameter("@DEPARTURE_TIME", t.Departure_Time));
                cmd.Parameters.Add(new SqlParameter("@LANDING_TIME", t.Landing_Time));
                cmd.Parameters.Add(new SqlParameter("@REMAINING_TICKETS", t.Remaining_Tickets));
                connection.Open();

                
                cmd.Connection.Close();

            }
            return newId;
        }

        public Flight Get(int id)
        {
            Flight t = new Flight();
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_FLIGHT_BY_ID", connection);
                cmd.Parameters.Add(new SqlParameter("@ID", id));
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while(reader.Read() == true)
                {
                    t.ID = (long)reader["ID"];
                    t.AirlineCompany_Id = (long)reader["AIRLINECOMPANY_ID"];
                    t.Origin_Country_Code = (long)reader["ORIGIN_COUNTRY_CODE"];
                    t.Destination_Country_Code = (long)reader["DESTINATION_COUNTRY_CODE"];
                    t.Departure_Time = (DateTime)reader["DEPARTURE_TIME"];
                    t.Landing_Time = (DateTime)reader["LANDING_TIME"];
                    t.Remaining_Tickets = (int)reader["REMAINING_TICKETS"];

                }
                cmd.Connection.Close();
                return t;
            }
        }

        public IList<Flight> GetAll()
        {
            List<Flight> List = new List<Flight>();
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_ALL_FLIGHTS", connection);

                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while (reader.Read() == true)
                {
                    Flight t = new Flight();
                    t.ID = (long)reader["ID"];
                    t.AirlineCompany_Id = (long)reader["AIRLINECOMPANY_ID"];
                    t.Origin_Country_Code = (long)reader["ORIGIN_COUNTRY_CODE"];
                    t.Destination_Country_Code = (long)reader["DESTINATION_COUNTRY_CODE"];
                    t.Departure_Time = (DateTime)reader["DEPARTURE_TIME"];
                    t.Landing_Time = (DateTime)reader["LANDING_TIME"];
                    t.Remaining_Tickets = (int)reader["REMAINING_TICKETS"];

                }
                cmd.Connection.Close();
                return List;
            }

        }

        public Dictionary<Flight, int> GetAllFlightsVacancy()
        {
            Dictionary<Flight, int> flights = new Dictionary<Flight, int>();
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_ALL_FLIGHT_VACANCY", connection);
                
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while (reader.Read() == true)
                {
                    Flight t = new Flight();
                    t.ID = (long)reader["ID"];
                    t.AirlineCompany_Id = (long)reader["AIRLINECOMPANY_ID"];
                    t.Origin_Country_Code = (long)reader["ORIGIN_COUNTRY_CODE"];
                    t.Destination_Country_Code = (long)reader["DESTINATION_COUNTRY_CODE"];
                    t.Departure_Time = (DateTime)reader["DEPARTURE_TIME"];
                    t.Landing_Time = (DateTime)reader["LANDING_TIME"];
                    t.Remaining_Tickets = (int)reader["REMAINING_TICKETS"];

                }
                cmd.Connection.Close();
                return flights;
            }
        }

        public Flight GetFlightById(int Id)
        {
            Flight t = new Flight();
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_FLIGHT_BY_ID", connection);
                cmd.Parameters.Add(new SqlParameter("@ID", Id));
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while (reader.Read() == true)
                {
                    t.ID = (long)reader["ID"];
                    t.AirlineCompany_Id = (long)reader["AIRLINECOMPANY_ID"];
                    t.Origin_Country_Code = (long)reader["ORIGIN_COUNTRY_CODE"];
                    t.Destination_Country_Code = (long)reader["DESTINATION_COUNTRY_CODE"];
                    t.Departure_Time = (DateTime)reader["DEPARTURE_TIME"];
                    t.Landing_Time = (DateTime)reader["LANDING_TIME"];
                    t.Remaining_Tickets = (int)reader["REMAINING_TICKETS"];

                }
                cmd.Connection.Close();
                return t;
            }
        }

        public IList<Flight> GetFlightsByAirlineCompany(AirlineCompany airline)
        {
            throw new NotImplementedException();
        }

        public IList<Flight> GetFlightsByCustomer(Customer customer)
        {
            List<Flight> List = new List<Flight>();
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_ALL_FLIGHT_BY_CUSTOMER", connection);
                cmd.Parameters.Add(new SqlParameter("@CUSTOMER_ID",customer.Id));
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while (reader.Read() == true)
                {
                    Flight t = new Flight();
                    t.ID = (long)reader["ID"];
                    t.AirlineCompany_Id = (long)reader["AIRLINECOMPANY_ID"];
                    t.Origin_Country_Code = (long)reader["ORIGIN_COUNTRY_CODE"];
                    t.Destination_Country_Code = (long)reader["DESTINATION_COUNTRY_CODE"];
                    t.Departure_Time = (DateTime)reader["DEPARTURE_TIME"];
                    t.Landing_Time = (DateTime)reader["LANDING_TIME"];
                    t.Remaining_Tickets = (int)reader["REMAINING_TICKETS"];

                }
                cmd.Connection.Close();
                return List;
            }
        }

        public IList<Flight> GetFlightsByDepartureDate(DateTime departureDate)
        {
            List<Flight> List = new List<Flight>();
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_ALL_FLIGHT_BY_DEPARTURE_TIME", connection);
                cmd.Parameters.Add(new SqlParameter("@DATE_TIME", departureDate));
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while (reader.Read() == true)
                {
                    Flight t = new Flight();
                    t.ID = (long)reader["ID"];
                    t.AirlineCompany_Id = (long)reader["AIRLINECOMPANY_ID"];
                    t.Origin_Country_Code = (long)reader["ORIGIN_COUNTRY_CODE"];
                    t.Destination_Country_Code = (long)reader["DESTINATION_COUNTRY_CODE"];
                    t.Departure_Time = (DateTime)reader["DEPARTURE_TIME"];
                    t.Landing_Time = (DateTime)reader["LANDING_TIME"];
                    t.Remaining_Tickets = (int)reader["REMAINING_TICKETS"];

                }
                cmd.Connection.Close();
                return List;
            }
        }

        public IList<Flight> GetFlightsByDestinationCountry(int countryCode)
        {
            List<Flight> List = new List<Flight>();
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_ALL_FLIGHT_BY_DESTINATION_COUNTRY", connection);
                cmd.Parameters.Add(new SqlParameter("@DESTINATION_COUNTRY", countryCode));
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while (reader.Read() == true)
                {
                    Flight t = new Flight();
                    t.ID = (long)reader["ID"];
                    t.AirlineCompany_Id = (long)reader["AIRLINECOMPANY_ID"];
                    t.Origin_Country_Code = (long)reader["ORIGIN_COUNTRY_CODE"];
                    t.Destination_Country_Code = (long)reader["DESTINATION_COUNTRY_CODE"];
                    t.Departure_Time = (DateTime)reader["DEPARTURE_TIME"];
                    t.Landing_Time = (DateTime)reader["LANDING_TIME"];
                    t.Remaining_Tickets = (int)reader["REMAINING_TICKETS"];

                }
                cmd.Connection.Close();
                return List;
            }
        }

        public IList<Flight> GetFlightsByLandingDate(DateTime landingDate)
        {
            List<Flight> List = new List<Flight>();
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_ALL_FLIGHT_BY_DEPARTURE_TIME", connection);
                cmd.Parameters.Add(new SqlParameter("@DATE_TIME", landingDate));
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while (reader.Read() == true)
                {
                    Flight t = new Flight();
                    t.ID = (long)reader["ID"];
                    t.AirlineCompany_Id = (long)reader["AIRLINECOMPANY_ID"];
                    t.Origin_Country_Code = (long)reader["ORIGIN_COUNTRY_CODE"];
                    t.Destination_Country_Code = (long)reader["DESTINATION_COUNTRY_CODE"];
                    t.Departure_Time = (DateTime)reader["DEPARTURE_TIME"];
                    t.Landing_Time = (DateTime)reader["LANDING_TIME"];
                    t.Remaining_Tickets = (int)reader["REMAINING_TICKETS"];

                }
                cmd.Connection.Close();
                return List;
            }
        }

        public IList<Flight> GetFlightsByOriginCountry(int countryCode)
        {
            List<Flight> List = new List<Flight>();
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_ALL_FLIGHT_BY_ORIGIN_COUNTRY", connection);
                cmd.Parameters.Add(new SqlParameter("@ORIGIN_COUNTRY", countryCode));
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while (reader.Read() == true)
                {
                    Flight t = new Flight();
                    t.ID = (long)reader["ID"];
                    t.AirlineCompany_Id = (long)reader["AIRLINECOMPANY_ID"];
                    t.Origin_Country_Code = (long)reader["ORIGIN_COUNTRY_CODE"];
                    t.Destination_Country_Code = (long)reader["DESTINATION_COUNTRY_CODE"];
                    t.Departure_Time = (DateTime)reader["DEPARTURE_TIME"];
                    t.Landing_Time = (DateTime)reader["LANDING_TIME"];
                    t.Remaining_Tickets = (int)reader["REMAINING_TICKETS"];

                }
                cmd.Connection.Close();
                return List;
            }
        }

        public void Remove(Flight t)
        {
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("REMOVE_FLIGHT", connection);
                cmd.Parameters.Add(new SqlParameter("@ID", t.ID));
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                cmd.Connection.Close();
            }
        }

        public void Update(Flight t)
        {
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("UPDATE_FLIGHT", connection);
                cmd.Parameters.Add(new SqlParameter("@ID", t.ID));
                cmd.Parameters.Add(new SqlParameter("@AIRLINECOMPANY_ID", t.AirlineCompany_Id));
                cmd.Parameters.Add(new SqlParameter("ORIGIN_COUNTRY_CODE", t.Origin_Country_Code));
                cmd.Parameters.Add(new SqlParameter("@DESTINATION_COUNTRY_CODE", t.Destination_Country_Code));
                cmd.Parameters.Add(new SqlParameter("@DEPARTURE_TIME", t.Departure_Time));
                cmd.Parameters.Add(new SqlParameter("@LANDING_TIME", t.Landing_Time));
                cmd.Parameters.Add(new SqlParameter("@REMAINING_TICKETS", t.Remaining_Tickets));
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                cmd.Connection.Close();

            }
        }
   }
}
