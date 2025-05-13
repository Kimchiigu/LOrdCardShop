using LOrdCardShop.Model;
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

        public static User ValidateLogin(string username, string password)
        {
            return UsersRepository.ValidateLogin(username, password);
        }

        public static User GetUserById(int id)
        {
            return UsersRepository.GetUserByID(id);
        }

        public static void UpdateUserWithPassword(User user)
        {
            UsersRepository.UpdateUserWithPassword(user);
        }

        public static void UpdateUserWithoutPassword(User user)
        {
            UsersRepository.UpdateUserWithoutPassword(user);
        }
    }
}