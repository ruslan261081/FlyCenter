﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
   public interface ILoggedInCustomerFacade
   {
        IList<Flight> GetAllMyFlights(LoginToken<Customer> token);
        long PurchaseTicket(LoginToken<Customer> token, Flight flihgt);
        void CancelTicket(LoginToken<Customer> token, Ticket ticket);
   }
}
