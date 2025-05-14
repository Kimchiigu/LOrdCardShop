using LOrdCardShop.Model;
using LOrdCardShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Handlers
{
    public class CartsHandler
    {
        public static List<Cart> GetAllCartsByUserId(int userId)
        {
            return CartsRepository.GetAllCartsByUserId(userId);
        } 

        public static void DeleteCart(int cartId)
        {
            CartsRepository.DeleteCart(cartId);
        }

        public static void ClearCart(int userId)
        {
            CartsRepository.ClearCart(userId);
        }

        public static void AddCardToCart(int cardId, int userId, int quantity)
        {
            CartsRepository.AddCardToCart(cardId, userId, quantity);
        }
    }
}