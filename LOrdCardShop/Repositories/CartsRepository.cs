using LOrdCardShop.Controllers;
using LOrdCardShop.Database;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Repositories
{
    public class CartsRepository
    {
        private static LordCardShopDatabaseEntities db = DatabaseSingleton.GetInstance();

        public static List<Cart> GetAllCartsByUserId(int userId)
        {
            return db.Carts.ToList().Where(c => c.UserID == userId).ToList();
        }

        public static void ClearCart(int userId)
        {
            db.Carts.RemoveRange(db.Carts.Where(c => c.UserID == userId));
            db.SaveChanges();
        }

        public static void DeleteCart(int cartId)
        {
            Cart deletedCart = db.Carts.Find(cartId);

            if (deletedCart != null)
            {
                db.Carts.Remove(deletedCart);
                db.SaveChanges();
            }
        }

        public static void AddCardToCart(int cardId, int userId, int quantity)
        {
            Cart existingCart = db.Carts
            .FirstOrDefault(c => c.CardID == cardId && c.UserID == userId);

            if (existingCart != null)
            {
                existingCart.Quantity += quantity;
            }
            else
            {
                Cart newCart = CartsFactory.CreateCart(cardId, userId, quantity);
                db.Carts.Add(newCart);
            }

            db.SaveChanges();
        }
    }
}