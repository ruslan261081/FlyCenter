using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
    public class AirlineCompany :  IPoco,IUser
    {
        public long ID { get; set; }
        public string AirlineName { get; set; }
        public long CountryCode { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public AirlineCompany()
        {

        }

        public AirlineCompany(string airlineName, int countryCode, string password, string userName)
        {
            AirlineName = airlineName;
            CountryCode = countryCode;
            Password = password;
            UserName = userName;
        }
        public static bool operator ==(AirlineCompany me, AirlineCompany other)
        {
       
            if (ReferenceEquals (me,other) || ReferenceEquals(me, null) && ReferenceEquals(other,null))
                return true;
            return false;
        }
        public static bool operator!=(AirlineCompany me, AirlineCompany other)
        {
            return !(me == other);
        }

        public override bool Equals(object obj)
        {
          
            AirlineCompany otherairlineCompany = obj as AirlineCompany;
           
                return(this.ID == otherairlineCompany.ID);
        }

        public override int GetHashCode()
        {
            return (int)this.ID;

        }

        public override string ToString()
        {
            return $"AirlineCompany AirlineName {AirlineName}, CountryCode {CountryCode}, Password {Password}, UserName {UserName}";
        }
    }
}
