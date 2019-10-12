using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
  public class CustomerDAOMSSQL : ICustomerDAO
  {
        public long Add(Customer t)
        {
            long newId = 0;
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("ADD_CUSTOMER", connection);
                cmd.Parameters.Add(new SqlParameter("@FIRST_NAME", t.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LAST_NAME", t.LastName));
                cmd.Parameters.Add(new SqlParameter("@USER_NAME", t.UserName));
                cmd.Parameters.Add(new SqlParameter("@PASSWORD", t.Password));
                cmd.Parameters.Add(new SqlParameter("@ADDRESS", t.Address));
                cmd.Parameters.Add(new SqlParameter("@PHONE_NO", t.PhoneNo));
                cmd.Parameters.Add(new SqlParameter("@CREDIT_CARD_NUMBER", t.CreditCardNumber));


                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                

                
                cmd.Connection.Close();

            }
            return newId;
        }
        public Customer Get(int id)
        {
            Customer t = new Customer();
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_CUSTOMER_BY_ID", connection);
                cmd.Parameters.Add(new SqlParameter("@ID", id));

                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while(reader.Read()== true)
                {


                    t.Id = (long)reader["ID"];
                    t.FirstName = (string)reader["FIRST_NAME"];
                    t.LastName = (string)reader["LAST_NAME"];
                    t.UserName = (string)reader["USER_NAME"];
                    t.Password = (string)reader["PASSWORD"];
                    t.Address = (string)reader["ADDRESS"];
                    t.PhoneNo = (int)reader["PHONO_NO"];
                    t.CreditCardNumber = (int)reader["CREDIT_CARD_NUMBER"];
                        
         
                    
                }
                cmd.Connection.Close();
                return t;
               
            }
        }

        public IList<Customer> GetAll()
        {
            List<Customer> List = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_ALL_CUSTOMER", connection);
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while(reader.Read()== true)
                {
                    Customer t = new Customer();
                    t.Id = (long)reader["ID"];
                    t.FirstName = (string)reader["FIRST_NAME"];
                    t.LastName = (string)reader["LAST_NAME"];
                    t.UserName = (string)reader["USER_NAME"];
                    t.Password = (string)reader["PASSWORD"];
                    t.Address = (string)reader["ADDRESS"];
                    t.PhoneNo = (int)reader["PHONO_NO"];
                    t.CreditCardNumber = (int)reader["CREDIT_CARD_NUMBER"];


                }
                cmd.Connection.Close();
                return List;

            }
        }

        public Customer GetCustomerByUserName(string username)
        {
            Customer t = new Customer();
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("GET_CUSTOMER_BY_USER_NAME", connection);
                cmd.Parameters.Add(new SqlParameter("@NAME", username));

                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                while(reader.Read()== true)
                {
                    t.Id = (long)reader["ID"];
                    t.FirstName = (string)reader["FIRST_NAME"];
                    t.LastName = (string)reader["LAST_NAME"];
                    t.UserName = (string)reader["USER_NAME"];
                    t.Password = (string)reader["PASSWORD"];
                    t.Address = (string)reader["ADDRESS"];
                    t.PhoneNo = (int)reader["PHONO_NO"];
                    t.CreditCardNumber = (int)reader["CREDIT_CARD_NUMBER"];

                }
                cmd.Connection.Close();
                return t;

            }
        }

        public void Remove(Customer t)
        {
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("REMOVE_CUSTOMER", connection);
                cmd.Parameters.Add(new SqlParameter("@ID", t.Id));
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                cmd.Connection.Close();
            }
        }

        public void Update(Customer t)
        {
            using (SqlConnection connection = new SqlConnection(FlightCenterConfig.CONNECTION_STRING))
            {
                SqlCommand cmd = new SqlCommand("ADD_CUSTOMER", connection);
                cmd.Parameters.Add(new SqlParameter("@FIRST_NAME", t.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LAST_NAME", t.LastName));
                cmd.Parameters.Add(new SqlParameter("@USER_NAME", t.UserName));
                cmd.Parameters.Add(new SqlParameter("@PASSWORD", t.Password));
                cmd.Parameters.Add(new SqlParameter("@ADDRESS", t.Address));
                cmd.Parameters.Add(new SqlParameter("@PHONE_NO", t.PhoneNo));
                cmd.Parameters.Add(new SqlParameter("@CREDIT_CARD_NUMBER", t.CreditCardNumber));

                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();


                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
                cmd.Connection.Close();

            }
        }
   }
}
