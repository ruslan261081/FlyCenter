﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
   public interface ICountryDAO : IBasicDB<Country>
   {
        string GetNameCountryById(int id);
   }
}
