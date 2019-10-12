using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyCenterProject
{
    public class Administrator :IPoco, IUser
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Administrator()
        {

        }

        public Administrator(long id, string userName, string password)
        {
            Id = id;
            UserName = userName;
            Password = password;
        }
        public static bool operator ==(Administrator me, Administrator other)
        {
            if (ReferenceEquals (me,other) || ReferenceEquals(me,null) && ReferenceEquals(other, null))
                return true;
            return false;
        }
        public static bool operator !=(Administrator me, Administrator other)
        {
            return !(me == other);
        }

        public override bool Equals(object obj)
        {
        
            Administrator otheradministrator = obj as Administrator;
            return (this.Id == otheradministrator.Id);
           
        }

        public override int GetHashCode()
        {
            return (int)this.Id;
        }

        public override string ToString()
        {
            return $"Admistrator Id {Id}, UserName {UserName}, Password {Password}";
        }
    }
}
