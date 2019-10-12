using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
   public  class Country : IPoco
   {
        public long Id { get; set; }
        public string CountryName { get; set; }

        public Country()
        {

        }

        public Country(long id, string countryName)
        {
            Id = id;
            CountryName = countryName;
        }

        public static bool operator ==(Country me, Country other)
        {
            if (ReferenceEquals(me, other) || ReferenceEquals(me, null) && ReferenceEquals(other, null))
                return true;
            return false;
        }  
        public static bool operator !=(Country me, Country other)
        {
            return !(me == other);
        }

        public override bool Equals(object obj)
        {
           
            Country otherCountry = obj as Country;
            return (this.Id == otherCountry.Id);
        }

        public override int GetHashCode()
        {
            return (int)this.Id; 
        }

        public override string ToString()
        {
            return $"Country Id {Id}, CountryName {CountryName}";
        }
    }
}
