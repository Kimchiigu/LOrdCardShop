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

        public static List<Card> GetAllCardsByName(string cardName)
        {
            return CardsRepository.GetAllCardsByName(cardName);
        }

        public static Card GetCardById(int id)
        {
            return CardsRepository.GetCardById(id);
        }
        public static void UpdateCard(int cardId, string cardName, double cardPrice, string cardDesc, string cardType, bool isFoil)
        {
            CardsRepository.UpdateCard(cardId, cardName, cardPrice, cardDesc, cardType, isFoil);
        }

        public static void AddCard(string cardName, double cardPrice, string cardDesc, string cardType, bool isFoil)
        {
            CardsRepository.AddCard(cardName, cardPrice, cardDesc, cardType, isFoil);
        }
    }
}