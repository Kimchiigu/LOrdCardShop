using LOrdCardShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Handlers
{
    public class UsersHandler
    {
        public static void AddUser(string username, string email, string password, string gender, string dob)
        {
            UsersRepository.AddUser(username, email, password, gender, dob);
        }
    }
}