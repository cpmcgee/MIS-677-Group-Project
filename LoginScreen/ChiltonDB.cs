using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen
{

    public partial class ChiltonDB : DBClassesDataContext
    {
        public Table<_User> Users;
        public Table<_LoginAttempt> LoginAttempts;
        public ChiltonDB(string connection) : base(connection) { }

        public List<_User> UserList
        {
            get
            {
                return (from u in Users
                        select u) as List<_User>;
            }
        }
    }
}
