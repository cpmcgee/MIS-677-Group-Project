﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LoginScreen
{

    public class ChiltonDB : DBClassesDataContext //currently no modified logic in this subclass implementation
    {
        //public Table<User> Users;
        //public Table<LoginAttempt> LoginAttempts;

        public static ChiltonDB instance = null;

        public ChiltonDB(string connection) : base(connection)
        {
            if (instance != null)
            {
                throw new Exception("a db connection already exists");
            }
            else
                instance = this;
        }

        public static ChiltonDB GetInstance()
        {
            return instance;
        }

        public string GetSystemDate()
        {
            string s = this.ExecuteQuery<string>(@"SELECT GETDATE() AS CurrentDateTime;", new object[] { }).Take(1).ToString();
            return s;
        }

        public static void Close()
        {
            instance.Connection.Close();
            instance.Dispose();
        }
    } 
}
