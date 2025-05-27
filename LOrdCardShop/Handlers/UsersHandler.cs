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

        public static string GetUsernameById(int id)
        {
            return UsersRepository.GetUsernameById(id);
        }

        public static User GetUserById(int id)
        {
            return UsersRepository.GetUserByID(id);
        }

        public static void UpdateUserWithPassword(int userId, string username, string userEmail, string userGender, string newPassword)
        {
            UsersRepository.UpdateUserWithPassword(userId, username, userEmail, userGender, newPassword);
        }

        public static void UpdateUserWithoutPassword(int userId, string username, string userEmail, string userGender)
        {
            UsersRepository.UpdateUserWithoutPassword(userId, username, userEmail, userGender);
        }
    }
}