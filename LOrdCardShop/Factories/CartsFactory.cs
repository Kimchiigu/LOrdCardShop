using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Controllers
{
    public class CartsFactory
    {
        public static Cart CreateCart(int cardId, int userId, int quantity)
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