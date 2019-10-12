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
