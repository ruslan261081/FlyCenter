﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
  interface ILoggedInAirlineFacede
  {
        IList<Ticket> GetAllTicketsByAirline(LoginToken<AirlineCompany> token);
        IList<Flight> GetAllFlightsByAirline(LoginToken<AirlineCompany> token);
        void CancelFlight(LoginToken<AirlineCompany> token, Flight flihgt);
        long CreateFlight(LoginToken<AirlineCompany> token, Flight flihgt);
        void UpdateFlight(LoginToken<AirlineCompany> token, Flight flihgt);
        void ChangeMyPassword(LoginToken<AirlineCompany> token, string oldPassword, string newPassword);
        void ModifyAirlineDetails(LoginToken<AirlineCompany> token, AirlineCompany airlineCompany);
        bool UserIsValid(LoginToken<AirlineCompany> token);
  }
}
