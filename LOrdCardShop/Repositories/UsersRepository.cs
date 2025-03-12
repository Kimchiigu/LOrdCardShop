using LOrdCardShop.Database;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Repositories
{
    public class UsersRepository
    {
        private static LordCardShopDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public static User GetUserByID(int id)
        {
            return db.Users.Find(id);
        }
    }
}