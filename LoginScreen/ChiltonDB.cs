using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen
{
    public partial class ChiltonDB : DataContext
    {
        public Table<User> Users;
        public ChiltonDB(string connection) : base(connection) { }
    }
}
