using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Factories
{
    public class UsersFactory
    {
        public static User CreateUser(string username, string email, string password, string gender, string dob)
        {
            User user = new User
            {
                UserName = username,
                UserPassword = password,
                UserEmail = email,
                UserGender = gender,
                UserDOB = DateTime.Parse(dob),
                UserRole = "customer"
            };
            return user;
        }
    }
}