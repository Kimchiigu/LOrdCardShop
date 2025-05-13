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

        internal static void UpdateCart(Cart existingCart)
        {
            //Dari function AddToCart
        }

        internal static void InsertCart(Cart newCart)
        {
            //Dari function AddToCart
        }
    }
}