using LOrdCardShop.Handlers;
using LOrdCardShop.Model;
using LOrdCardShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Controllers
{
    public class CartsController
    {
        public static List<Cart> GetAllCartsByUserId(int userId)
        {
            return CartsHandler.GetAllCartsByUserId(userId);    
        }

        public static void DeleteCart(int cartId)
        {
            CartsHandler.DeleteCart(cartId);
        }

        public static void ClearCart(int userId)
        {
            CartsHandler.ClearCart(userId);
        }

        public static void AddCardToCart(int cardId, int userId, int quantity)
        {
            CartsHandler.AddCardToCart(cardId, userId, quantity);
        }
    }
}