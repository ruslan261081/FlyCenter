using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlyCenterProject;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using System;


namespace FlyCenterTest
{
    [TestClass]
   public class TestCenter 
   {
      /*  public const long FLIGHT_ID = 7;
        public const long AIRLINE_COMPANY_ID = 2;
        public const int VACANCY = 50;
        public const long ORIGIN_COUNTRY_CODE = 2;
        public const long DESTINATION_COUNTRY_CODE = 3;
        public static DateTime DEPARTURE_TIME = new DateTime(2019,10,26,13,0,0);
        public static DateTime LANDING_TIME = new DateTime(2019,10,26,16,0,0);
        public const string AIRLINE_NAME = "AZAL";
        public const string AIRLINE_USERNAME = "261081";
        public const string AIRLINE_PASSWORD = "261081";
        public const long COUNTRY_CODE = 1;
        public const string NEW_AIRLINE_PASSWORD = "777";
        public static List<long> airlineId = new List<long>() {8,9,10,11 };
        public static List<string> airlineNames = new List<string>() {"Azal","Delta","Alitalia","CanJet", };
        public static List<long> airlineCountryCodes = new List<long>() { 4,5,6,7};
        public const string CUSTOMER_USERNAME = "Az123";
        public const string CUTSOMER_PASSWORD = "Password1!";
        public static List<long> FlightsId = new List<long>() { 6,7 };
        public static List<long> AirlieCompaniesId = new List<long>() { 1,2 };
        public static List<long> OriginCountryCodes = new List<long>() { 2,3};
        public static List<long> DestinationCountryCodes = new List<long>() {3,2 };
        public static List<int> Vacancies = new List<int>() { 50,30 };
        public static List<DateTime> DepartureTimes = new List<DateTime>() { new DateTime(2019, 10, 26, 13, 0, 0), new DateTime(2019, 11, 02, 13, 0, 0) };
        public static List<DateTime> LandingTimes = new List<DateTime>() { new DateTime(2019, 10, 26, 16, 0, 0), new DateTime(2019, 11, 02, 16, 0, 0) };
        public const string adminName = "admin";
        public const string adminPassword = "9999";
        public static List<long> ticketsId = new List<long>() { 12,13};
        public static List<long> ticketsFlightsId = new List<long>() { 34,38};
        public static List<long> ticketsCustomersId = new List<long>() { 2,4};*/





        public static void CleanAllDatabase()
        {
            using (SqlConnection conn = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                using (SqlCommand cmd = new SqlCommand("CLEAN_ALL_DB", conn))
                {
                    cmd.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
               
            }
        }
      


   }
}
