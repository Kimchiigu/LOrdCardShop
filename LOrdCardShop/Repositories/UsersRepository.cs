using LOrdCardShop.Database;
using LOrdCardShop.Factories;
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

        public static User ValidateLogin(string username, string password)
        {
            return db.Users.Where(u => u.UserName == username && u.UserPassword == password).FirstOrDefault();
        }

        public static List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public static User GetUserByID(int id)
        {
            return db.Users.Find(id);
        }

        public static void AddUser(string username, string email, string password, string gender, string dob)
        {
            User user = UsersFactory.CreateUser(username, email, password, gender, dob);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static List<Card> GetFeaturedCards()
        {
            List<Card> featuredCards = db.Cards.OrderBy(c => Guid.NewGuid())
                .Take(6)
                .ToList();

            return featuredCards;
        }

        public static Cart GetCartItem(int userId, int cardId)
        {
            Cart cart = db.Carts
                .Where(c => c.UserID == userId && c.CardID == cardId)
                .FirstOrDefault();
            return cart;
        }

        public static void UpdateUserWithoutPassword(int userId, string username, string userEmail, string userGender)
        {
            User oldUser = db.Users.Find(userId);
            if (oldUser != null)
            {
                oldUser.UserName = username;
                oldUser.UserEmail = userEmail;
                oldUser.UserGender = userGender;

                db.SaveChanges();
            }
        }

        public static void UpdateUserWithPassword(int userId, string username, string userEmail, string userGender, string newPassword)
        {
            User oldUser = db.Users.Find(userId);
            if (oldUser != null)
            {
                oldUser.UserName = username;
                oldUser.UserEmail = userEmail;
                oldUser.UserGender = userGender;
                oldUser.UserPassword = newPassword;

                db.SaveChanges();
            }
        }
    }
}