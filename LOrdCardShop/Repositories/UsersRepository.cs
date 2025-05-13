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

        public static void UpdateUserWithoutPassword(User user)
        {
            User oldUser = db.Users.Find(user.UserID);
            if (oldUser != null)
            {
                oldUser.UserName = user.UserName;
                oldUser.UserEmail = user.UserEmail;
                oldUser.UserGender = user.UserGender;

                db.SaveChanges();
            }
        }

        public static void UpdateUserWithPassword(User user)
        {
            User oldUser = db.Users.Find(user.UserID);
            if (oldUser != null)
            {
                oldUser.UserName = user.UserName;
                oldUser.UserEmail = user.UserEmail;
                oldUser.UserGender = user.UserGender;
                oldUser.UserPassword = user.UserPassword;

                db.SaveChanges();
            }
        }
    }
}