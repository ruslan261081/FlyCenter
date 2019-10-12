using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
    public class Customer : IPoco, IUser
    {
        public long Id { get; set; }
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int PhoneNo { get; set; }
        public int CreditCardNumber { get; set; }

        public Customer()
        {

        }

        public Customer(long id, string firstName, string lastName, string userName, string password, string address, int phoneNo, int creditCardNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Address = address;
            PhoneNo = phoneNo;
            CreditCardNumber = creditCardNumber;
        }

        public static bool operator == (Customer me, Customer other)
        {
            if (ReferenceEquals(me,other) || ReferenceEquals(me, null) && ReferenceEquals( other, null))
                return true;
             return false;
        }
        public static bool operator !=(Customer me, Customer other)
        {
            return !(me == other);
        }

        public override bool Equals(object obj)
        {
            
            Customer otherCustomer = obj as Customer;
          
            return (this.Id == otherCustomer.Id);
        }

        public override int GetHashCode()
        {
            return(int)this.Id;
        }
        public override string ToString()
        {
            return $"Customer Id {Id}, FirstName {FirstName}, LastName {LastName}, UserName {UserName}, Password {Password}, Address {Address},PhoneNo {PhoneNo}, CreditNumber {CreditCardNumber}";
        }
    }
}
