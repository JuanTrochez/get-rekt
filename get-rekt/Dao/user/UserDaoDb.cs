﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using get_rekt.Models;

namespace get_rekt.Dao.user
{
    public class UserDaoDb : IUserDao
    {
        public UserDaoDb() { }
        public UserModel getUser(string email)
        {
            Context contextUser = new Context();

            UserModel user = contextUser.Users
                .Where(u => u.Email == email)
                .FirstOrDefault();

            return user;
        }
    }
}