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

        public static List<Card> GetFeaturedCards()
        {
            return UsersRepository.GetFeaturedCards();
        }

        internal static string AddToCart(int userId, int cardId, int quantity)
        {
            Cart existingCart = UsersRepository.GetCartItem(userId, cardId);
            if (existingCart != null)
            {
                existingCart.Quantity += quantity;
                UsersRepository.UpdateCart(existingCart);
                return "Cart updated!";
            }
            else
            {
                Cart newCart = new Cart
                {
                    UserID = userId,
                    CardID = cardId,
                    Quantity = quantity
                };
                UsersRepository.InsertCart(newCart);
                return "Card added to cart!";
            }
        }
    }
}