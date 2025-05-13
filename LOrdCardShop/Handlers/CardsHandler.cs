using LOrdCardShop.Model;
using LOrdCardShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Handlers
{
    public class CardsHandler
    {
        public static List<Card> GetAllCards()
        {
            return CardsRepository.GetAllCards();
        }

        public static Card GetCardById(int id)
        {
            return CardsRepository.GetCardById(id);
        }
        public static void UpdateCard(Card updatedCard)
        {
            CardsRepository.UpdateCard(updatedCard);
        }
    }
}