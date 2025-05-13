using LOrdCardShop.Handlers;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Controllers
{
    public class CardsController
    {
        public static List<Card> GetAllCards()
        {
            return CardsHandler.GetAllCards();
        }

        public static Card GetCardById(int id)
        {
            return CardsHandler.GetCardById(id);
        }
    }
}