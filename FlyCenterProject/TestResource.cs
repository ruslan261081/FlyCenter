using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
   public class TestResource
   {
        public const string Administrator_USER_NAME = "admin";
        public const string Administrator_PASSWORD = "9999";
        public const string Administrator_WrongPassword_PASSWORD = "7777";

        public const string AdministratorFacade_AddCustomer_FIRST_NAME = "Silvester";
        public const string AdministratorFacade_AddCustomer_LAST_NAME = "Stallone";
        public const string AdministratorFacade_AddCustomer_USER_NAME = "Rambo";
        public const string AdministratorFacade_AddCustomer_PASSWORD = "First Blood";
        public const string AdministratorFacade_AddCustomer_ADDRESS = "Hollywood";
        public const int AdministratorFacade_AddCustomer_PHONE_NO = 974567834;
        public const int AdministratorFacade_AddCustomer_CREDIT_CARD_NUMBER = 34567890;

        public const string Administrator_UpdateCustomer_FIRST_NAME = "Arnold";
        public const string Administrator_UpdateCustomer_LAST_NAME = "Schwarzenegger";
        public const string Administrator_UpdateCustomer_USER_NAME = "Terminator";
        public const string Administrator_UpdateCustomer_PASSWORD = "I'm be back";
        public const string Administrator_UpdateCustomer_PHONE_NO = "567893";
        public const string Administrator_UpdateCustomer_ADDRESS = "California";
        public const string Administrator_UpdateCustomer_CREDIT_CARD_NUMBER = "5678932";

        public const string AdministratorFacade_AddCountry_COUNTRY_NAME1 = "Usa";
        public const string AdministratorFacade_AddCountry_COUNTRY_NAME2 = "Austria";

        public const string AdministratorFacade_AddAirlineCompany1_AIRLINE_NAME = "Delta";
        public const string AdministratorFacade_AddAirlineCompany1_User_NAME = "Del2345";
        public const string AdministratorFacade_AddAirlineCompany1_PASSWORD = "12345";

        public const string AdministratorFacade_AddAirlineCompany2_AIRLINE_NAME = "Austrian Airlines";
        public const string AdministratorFacade_AddAirlineCompany2_USER_NAME = "Aus1234";
        public const string AdministratorFacade_AddAirlineCompany2_PASSWORD = "A2345";

        public const string AdministratorFacade_UpdateAirlineCompany_AIRLINE_NAME = "El-Al";
        public const string AdministratorFacade_UpdateAirlineCompany_USER_NAME = "Al12345";
        public const string AdministratorFacade_UpdateAirlineCompany_PASSWORD = "E234567";
        
        public const string AirlineCompanyFacade_AIRLINE_NAME = "El-Al";
        public const string AirlineCompanyfacade_USER_NAME = "Al12345";
        public const string AirlineCompanyFacade_PASSWORD = "E234567";

        public const string AirlineCompanyFacade_AirlineCompanyWrongPassword_PASSWORD = "7777";

        public const string AirlineCompanyFacade_Update_AIRLINE_NAME = "El-Al Tours";
        public const string AirlineCompanyFacade_NewPassword_PASSWORD = "E234567";

        public static DateTime AirlineCompanyFacade_AddNewFlight_DEPARTURE_TIME = DateTime.ParseExact("2019-10-26 12:00:00","yyyy-MM-dd HH:mm:ss", null);
        public static DateTime AirlineCompanyFacade_AddNewFlight_LANDING_TIME = DateTime.ParseExact("2019-10-26 15:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public const int AirlineCompanyFacade_AddNewFlight_REMAINING_TICKETS = 100;

        public static DateTime AirlineCompanyFacade_UpdateFlight_DEPARTURE_TIME = DateTime.ParseExact("2019-10-26 20:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public static DateTime AirlineCompanyFacade_UpdateFlight_LANDING_TIME = DateTime.ParseExact("2019-10-26 24:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public const int AirlineCompanyFacade_UpdateFlight_REMAINING_TICKETS = 50;

        public static DateTime AirlineCompanyFacade_UpdateFlight2_DEPARTURE_TIME = DateTime.ParseExact("2019-10-26 10:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public static DateTime AirlineCompanyFacade_UpdateFlight2_LANDING_TIME = DateTime.ParseExact("2019-10-26 21:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public const int AirlineCompanyFacade_UpdateFlight2_REMAINING_TICKETS = 12;

        public const string AirlineCompanyFacade_AddNewCountry1_COUNTRY_NAME = "Usa";
        public const string AirlineCompanyFacade_AddNewCountry2_COUNTRY_NAME = "Austria";

        public const string AirlineFacade_Customer1_FIRST_NAME = "Silvester";
        public const string AirlineFacade_Customer1_LAST_NAME = "Stallone";
        public const string AirlineFacade_Customer1_USER_NAME = "Rambo";
        public const string AirlineFacade_Customer1_PASSWORD = "First Blood";
        public const string AirlineFacade_Customer1_ADDRESS = "Hollywood";
        public const int AirlineFacade_Customer1_PHONE_NO = 974567834;
        public const int AirlineFacade_Customer1_CREDIT_CARD_NUMBER = 34567890;

        public const string AirlineFacade_Customer2_FIRST_NAME = "Arnold";
        public const string AirlineFacade_Customer2_LAST_NAME = "Schwarzenegger";
        public const string AirlineFacade_Customer2_USER_NAME = "Terminator";
        public const string AirlineFacade_Customer2_PASSWORD = "I'm be back";
        public const string AirlineFacade_Customer2_PHONE_NO = "567893";
        public const string AirlineFacade_Customer2_ADDRESS = "California";
        public const string AirlineFacade_Customer2_CREDIT_CARD_NUMBER = "5678932";

        public const string CustomerFacade_Customer_FIRST_NAME = "Silvester";
        public const string CustomerFacade_Customer_LAST_NAME = "Stallone";
        public const string CustomerFacade_Customer_USER_NAME = "Rambo";
        public const string CustomerFacade_Customer_PASSWORD = "First Blood";
        public const string CustomerFacade_Customer_ADDRESS = "Hollywood";
        public const int CustomerFacade_Customer_PHONE_NO = 974567834;
        public const int CustomerFacade_Customer_CREDIT_CARD_NUMBER = 34567890;

        public const string CustomerFacade_CustomerWrongPassword_Password = "2345";

        public static DateTime CustomerFacade_AddFlight_DEPARTURE_TIME = DateTime.ParseExact("2019-10-26 10:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public static DateTime CustomerFacade_AddFlight_LANDING_TIME = DateTime.ParseExact("2019-10-26 21:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public const int CustomerFacade_AddFlight_REMAINING_TICKETS = 100;

        public const string CustomerFacade_AirlineCompany1_AIRLINE_NAME = "Delta";
        public const string CustomerFacade_AirlineCompany1_User_NAME = "Del2345";
        public const string CustomerFacade_AirlineCompany1_PASSWORD = "12345";

        public const string CustomerFacade_AirlineCompany2_AIRLINE_NAME = "Austrian Airlines";
        public const string CustomerFacade_AirlineCompany2_USER_NAME = "Aus1234";
        public const string CustomerFacade_AirlineCompany2_PASSWORD = "A2345";

        public static DateTime CustomerFacade_UpdateFlight_DEPARTURE_TIME = DateTime.ParseExact("2019-10-26 10:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public static DateTime CustomerFacade_UpdateFlight_LANDING_TIME = DateTime.ParseExact("2019-10-26 21:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public const int CustomerFacade_Updatelight_REMAINING_TICKETS = 37;

        public const string AnonymousFacade_Anonymous_USER_NAME = "ENTER Your Name";
        public const string AnonymousFacade_AnonymousWrongPASSWORD = "7777";

        public static DateTime AnonymousFacade_DEPARTURE_TIME = DateTime.ParseExact("2019-10-26 10:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public static DateTime AnonymousFacade_LANDING_TIME = DateTime.ParseExact("2019-10-26 21:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public const int AnonymousFacade_REMAINING_TICKETS = 100;

        public static DateTime AnonymousFacade_UpdateFlight_DEPARTURE_TIME = DateTime.ParseExact("2019-10-26 10:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public static DateTime AnonymousFacade_UpdateFlight_LANDING_TIME = DateTime.ParseExact("2019-10-26 21:00:00", "yyyy-MM-dd HH:mm:ss", null);
        public const int AnonymousFacade_Updatelight_REMAINING_TICKETS = 45;

        public const string AnonymousFacade_AirlineCompany1_AIRLINE_NAME = "Delta";
        public const string AnonymousFacade_AirlineCompany1_User_NAME = "Del2345";
        public const string AnonumousFacade_AirlineCompany1_PASSWORD = "12345";


        public const string AnonymousFacade_AirlineCompany2_AIRLINE_NAME = "Austrian Airlines";
        public const string AnonymousFacade_AirlineCompany2_USER_NAME = "Aus1234";
        public const string AnonymousFacade_AirlineCompany2_PASSWORD = "A2345";

        public const string AnonymousFacade_Customer_FIRST_NAME = "Silvester";
        public const string AnonymousFacade_Customer_LAST_NAME = "Stallone";
        public const string AnonymousFacade_Customer_USER_NAME = "Rambo";
        public const string AnonymousFacade_Customer_PASSWORD = "First Blood";
        public const string AnonymousFacade_Customer_ADDRESS = "Hollywood";
        public const int AnonymousFacade_Customer_PHONE_NO = 974567834;
        public const int AnonymousFacade_Customer_CREDIT_CARD_NUMBER = 34567890;





   }
}
