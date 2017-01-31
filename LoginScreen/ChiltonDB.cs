using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen
{

    public partial class ChiltonDB : DBClassesDataContext //currently no modified logic in this subclass implementation
    {
        //public Table<User> Users;
        //public Table<LoginAttempt> LoginAttempts;
        public ChiltonDB(string connection) : base(connection) { }

        public List<User> UserList
        {
            get
            {
                return (from u in Users
                        select u) as List<User>;
            }
        }
    }
}
