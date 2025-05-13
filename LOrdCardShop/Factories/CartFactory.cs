using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Controllers
{
    public class CartFactory
    {
        public static Cart CreateCart(int userId, int cardId, int quantity)
        {
            Cart cart = new Cart
            {
                UserID = userId,
                CardID = cardId,
                Quantity = quantity
            };
            return cart;
        }
    }
}