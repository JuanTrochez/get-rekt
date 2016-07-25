using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using get_rekt.Models;

namespace get_rekt.Dao.user
{
    public class UserDao : IUserDao
    {
        UserModel user = new UserModel();
        public UserModel getUser(string email)
        {
            throw new NotImplementedException();
        }
    }
}